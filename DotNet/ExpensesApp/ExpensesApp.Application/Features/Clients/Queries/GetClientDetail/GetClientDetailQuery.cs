using MediatR;

namespace ExpensesApp.Application.Features.Clients.Queries.GetClientDetail
{
    public class GetClientDetailQuery : IRequest<ClientDetailDTO>
    {
        public int ClientId { get; set; }
    }
}
