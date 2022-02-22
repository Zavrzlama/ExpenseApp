using MediatR;

namespace ExpensesApp.Application.Features.Stores.Commands.Delete
{
    public class DeleteStoreCommand : IRequest
    {
        public int StoreId { get; set; }
    }
}
