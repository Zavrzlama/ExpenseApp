using MediatR;

namespace ExpensesApp.Application.Features.Stores.Commands.Update
{
    public class UpdateStoreCommand : IRequest<UpdateStoreCommandResponse>
    {

        public int StoreId { get; set; }

        public string Code { get; set; }

        public string StoreName { get; set; }
    }
}
