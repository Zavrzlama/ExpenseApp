using MediatR;
using System.Collections.Generic;

namespace ExpensesApp.Application.Features.Clients.Queries.GetClientList
{
    public class GetClientListQuery : IRequest<List<GetClientsListDTO>>
    {
    }
}
