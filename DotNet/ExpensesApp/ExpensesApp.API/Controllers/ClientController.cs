using System.Collections.Generic;
using System.Threading.Tasks;
using ExpensesApp.Application.Features.Clients.Commands.CreateClient;
using ExpensesApp.Application.Features.Clients.Commands.DeleteClient;
using ExpensesApp.Application.Features.Clients.Commands.UpdateClient;
using ExpensesApp.Application.Features.Clients.Queries.GetClientDetail;
using ExpensesApp.Application.Features.Clients.Queries.GetClientList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;


        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllClients")]
        public async Task<ActionResult<List<ClientsListDTO>>> GetAllClients()
        {
            var clients = await _mediator.Send(new GetClientListQuery());
            return Ok(clients);
        }

        [HttpGet("{id}", Name = "GetClient")]
        public async Task<ActionResult<ClientDetailDTO>> GetClient(int id)
        {
            var client = new GetClientDetailQuery() { ClientId = id };

            return Ok(await _mediator.Send(client));
        }

        [HttpPost(Name = "CreateClient")]
        public async Task<ActionResult<CreateClientCommandResponse>> CreateClient(
            [FromBody] CreateClientCommand createCommand)
        {
            var response = await _mediator.Send(createCommand);

            if (response.Success)
                return Ok(response.Client);

            return BadRequest(response.ValidationErrors);
        }

        [HttpPut(Name = "UpdateClient")]
        public async Task<ActionResult<UpdateClientCommandResponse>> UpdateClient(UpdateClientCommand command)
        {
            var response = await _mediator.Send(command);

            if (!response.IsFound)
                return NotFound();

            if (!response.Success)
                return BadRequest(response.ValidationErrors);

            return NoContent();
        }

        [HttpDelete("{id}",Name = "DeleteClient")]
        public async Task<ActionResult> DeleteClient(int id)
        {
            var request = new DeleteClientCommand() { ClientId = id };
            var response = await _mediator.Send(request);

            return NoContent();
        }
    }
}