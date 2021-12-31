using MediatR;

namespace ExpensesApp.Application.Features.Stores.Queries.GetStoreDetail
{
    public class GetStoreDetailQuery : IRequest<StoreDetailDTO>
    {
        public int StoreId { get; set; }
    }
}
