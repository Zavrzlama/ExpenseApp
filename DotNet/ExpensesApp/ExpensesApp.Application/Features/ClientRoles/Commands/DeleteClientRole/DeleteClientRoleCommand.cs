using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.DeleteClientRole
{
    public class DeleteClientRoleCommand : IRequest
    {
        public int ClientRoleId;
    }
}
