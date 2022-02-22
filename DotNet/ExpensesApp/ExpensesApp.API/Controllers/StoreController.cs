using ExpensesApp.Application.Features.Stores.Commands.Create;
using ExpensesApp.Application.Features.Stores.Commands.Delete;
using ExpensesApp.Application.Features.Stores.Commands.Update;
using ExpensesApp.Application.Features.Stores.Queries.GetStoreDetail;
using ExpensesApp.Application.Features.Stores.Queries.GetStoresList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExpensesApp.Api.Controllers
{

    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        public IMediator _mediator { get; private set; }

        public StoreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllStores")]
        public async Task<ActionResult<StoresListDTO>> GetAllStores()
        {
            var request = new GetStoresListQuery();
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpGet("{id}", Name = "GetStore")]
        public async Task<ActionResult<StoresListDTO>> GetStore(int id)
        {
            var request = new GetStoreDetailQuery() { StoreId = id };
            var response = await _mediator.Send(request);

            return Ok(response);
        }

        [HttpPost(Name = "CreateStore")]
        public async Task<ActionResult<CreateStoreCommandResponse>> CreateStore(CreateStoreCommand command)
        {
            var response = await _mediator.Send(command);

            if (response.Success)
                return Ok(response.Store);

            return BadRequest(response.ValidationErrors);
        }

        [HttpPut(Name = "UpdateStore")]
        public async Task<ActionResult<UpdateStoreCommandResponse>> UpdateStore(UpdateStoreCommand command)
        {
            var response = await _mediator.Send(command);

            if (!response.Success)
                return BadRequest(response.ValidationErrors);

            if (!response.StoreExists)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}",Name = "DeleteStore")]
        public async Task<ActionResult> DeleteStore(int id)
        {
            var request = new DeleteStoreCommand() { StoreId = id };
            await _mediator.Send(request);

            return NoContent();
        }
    }
}
