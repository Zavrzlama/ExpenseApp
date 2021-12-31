using ExpensesApp.Application.Features.Stores.Queries.GetStoreDetail;
using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.Stores.Commands.Create
{
    public class CreateStoreCommandResponse : BaseResponse
    {
        public CreateStoreCommandResponse() : base()
        {
        }

        public StoreDetailDTO Store { get; set; }

    }
}
