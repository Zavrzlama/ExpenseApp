using MediatR;

namespace ExpensesApp.Application.Features.Clients.Queries.GetClientDetail
{
    public class GetClientDetailQuery : IRequest<GetClientDetailDTO>
    {
        public int ClientId { get; set; }
    }
}
