using System.Collections.Generic;
using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleList
{
    public class GetClientRolesListQuery : IRequest<List<ClientRolesListDTO>>
    {
        
    }
}
