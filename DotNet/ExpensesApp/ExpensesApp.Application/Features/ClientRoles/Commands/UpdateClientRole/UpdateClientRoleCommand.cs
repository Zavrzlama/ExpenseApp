using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole
{
    public class UpdateClientRoleCommand : IRequest<UpdateClientRoleCommandResponse>
    {
        public int ClientRoleId { get; set; }
        public string Code { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

    }
}
