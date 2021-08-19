using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail
{
    public class GetClientRolesDetailQuery : IRequest<ClientRoleDetailDTO>
    {
        public int Id { get; set; }
    }
}
