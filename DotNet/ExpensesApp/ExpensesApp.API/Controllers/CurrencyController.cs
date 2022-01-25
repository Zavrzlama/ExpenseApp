using ExpensesApp.Application.Features.Currencies.Commands.Create;
using ExpensesApp.Application.Features.Currencies.Commands.Delete;
using ExpensesApp.Application.Features.Currencies.Commands.Update;
using ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyDetail;
using ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpensesApp.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CurrencyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCurrencies")]
        public async Task<ActionResult<List<CurrencyListDTO>>> GetAllCurrencies()
        {
            var request = new GetCurrencyListQuery();
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{id}", Name = "GetCurrency")]
        public async Task<ActionResult<CurrencyDetailDTO>> GetCurrency(int id)
        {
            var request = new GetCurrencyDetailQuerey() { CurrencyId = id };
            var response = _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost(Name = "CreateCurrency")]
        public async Task<ActionResult<CreateCurrencyCommandResponse>> CreateCurrency(CreateCurrencyCommand command)
        {
            var response = await _mediator.Send(command);

            if (response.Success)
                return Ok(response.Currency);

            return BadRequest(response.ValidationErrors);
        }

        [HttpPut(Name = "UpdateCurrency")]
        public async Task<ActionResult<UpdateCurrencyCommandResponse>> UpdateCurrency(UpdateCurrencyCommand command)
        {
            var response = await _mediator.Send(command);

            if (!response.CurrencyExists)
                return NotFound();

            if (!response.Success)
                return BadRequest(response.ValidationErrors);

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCurrency")]
        public async Task<ActionResult> DeleteCurrency(int id)
        {
            var request = new DeleteCurrencyCommand() { CurrencyId = id };
            var response = await _mediator.Send(request);

            return NoContent();
        }

    }
}