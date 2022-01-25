using ExpensesApp.Application.Features.Cities.Commands.Create;
using ExpensesApp.Application.Features.Cities.Commands.Delete;
using ExpensesApp.Application.Features.Cities.Commands.Update;
using ExpensesApp.Application.Features.Cities.Queries.GetCityDetail;
using ExpensesApp.Application.Features.Cities.Queries.GetCityList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpensesApp.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all",Name = "GetAllCities")]
        public async Task<ActionResult<List<CityListDTO>>> GetAllCities()
        {
            var request = new GetCityListQuery();
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{id}",Name ="GetCity")]
        public async Task<ActionResult<CityDetailDTO>> GetCity(int id)
        {
            var request = new GetCityDetailQuery() { CityId = id};
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost(Name = "CreateCity")]
        public async Task<ActionResult<CreateCityCommandResponse>> CreateCity(CreateCityCommand command)
        {
            var response = await _mediator.Send(command);

            if (response.Success)
                return Ok(response.City);

            return BadRequest(response.ValidationErrors);
        }

        [HttpPut(Name ="UpdateCity")]
        public async Task<ActionResult<UpdateCityCommandResponse>> UpdateCity(UpdateCityCommand command)
        {
            var response = await _mediator.Send(command);

            if (!response.IsFound)
                return NotFound();

            if (!response.Success)
                return BadRequest(response.ValidationErrors);

            return NoContent();
        }

        [HttpDelete("{id}",Name ="DeleteCity")]
        public async Task<ActionResult> DeleteCity(int id)
        {
            var request = new DeleteCityCommand() { CityId = id };
            var response = await _mediator.Send(request);
            
            return NoContent();
        }
    }
}
