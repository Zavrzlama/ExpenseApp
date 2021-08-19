using System.Collections.Generic;
using System.Threading.Tasks;
using ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientRoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientRoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllClientRoles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ClientRolesListDTO>>> GetAllClinetRoles()
        {
            var clientRoles = await _mediator.Send(new GetClientRolesListQuery());

            return Ok(clientRoles);
        }

        [HttpPost(Name ="AddClientRole")]
        public async Task<ActionResult<CreateClientRoleCommandResponse>> Create([FromBody] CreateClientRoleCommand createClientRoleCommand)
        {
            var response = await _mediator.Send(createClientRoleCommand);

            return Ok(response);
        }
    }
}
