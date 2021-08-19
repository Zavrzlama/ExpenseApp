using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole
{
    public class UpdateClientRoleCommand : IRequest
    {
        public int ClientRoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

    }
}
