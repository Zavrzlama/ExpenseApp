using System.Collections.Generic;
using System.Threading.Tasks;
using ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole;
using ExpensesApp.Application.Features.ClientRoles.Commands.DeleteClientRole;
using ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail;
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
        public async Task<ActionResult<List<ClientRolesListDTO>>> GetAllClientRoles()
        {
            var clientRoles = await _mediator.Send(new GetClientRolesListQuery());

            return Ok(clientRoles);
        }

        [HttpGet("{id}", Name = "GetCLientRole")]
        public async Task<ActionResult<ClientRoleDetailDTO>> GetClientRole (int id)
        {
            var clientRole = new GetClientRolesDetailQuery() { Id = id };

            return Ok(await _mediator.Send(clientRole));
        }

        [HttpPost(Name = "AddClientRole")]
        public async Task<ActionResult<CreateClientRoleCommandResponse>> Create(
            [FromBody] CreateClientRoleCommand createCommand)
        {
            var response = await _mediator.Send(createCommand);

            if (response.Success)
            {
                return Ok(response.ClientRole);
            }

            return BadRequest(response.ValidationErrors);
        }

        [HttpPut(Name = "UpdateClientRole")]
        public async Task<ActionResult<UpdateClientRoleCommandResponse>> Update(
            [FromBody] UpdateClientRoleCommand updateCommand)
        {
            var response = await _mediator.Send(updateCommand);

            if (!response.IsFound)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteClientRole")]
        public async Task<ActionResult> Delete(int id)
        {
            var clientRole = new DeleteClientRoleCommand() { ClientRoleId = id };
            await _mediator.Send(clientRole);

            return NoContent();
        }
    }
}