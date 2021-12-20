using System.Collections.Generic;
using System.Threading.Tasks;
using ExpensesApp.Application.Features.Clients.Commands.CreateClient;
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
        public async Task<ActionResult<List<GetClientsListDTO>>> GetAllClients()
        {
            var clients = await _mediator.Send(new GetClientListQuery());
            return Ok(clients);
        }

        [HttpGet("{id}", Name = "GetClient")]
        public async Task<ActionResult<GetClientDetailDTO>> GetClient(int id)
        {
            var client = new GetClientDetailQuery() { ClientId = id };

            return Ok(await _mediator.Send(client));
        }

        [HttpPost(Name = "CreateClient")]
        public async Task<ActionResult<CreateClientCommandResponse>> Create(
            [FromBody] CreateClientCommand createCommand)
        {
            var response = await _mediator.Send(createCommand);

            if (response.Success)
                return Ok(response.Client);

            return BadRequest(response.ValidationErrors);
        }
    }
}