using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.Stores.Commands.Update
{
    public class UpdateStoreCommandResponse : BaseResponse
    {
        public UpdateStoreCommandResponse() : base()
        {
            
        }

        public bool StoreExists { get; set; }
    }
}
