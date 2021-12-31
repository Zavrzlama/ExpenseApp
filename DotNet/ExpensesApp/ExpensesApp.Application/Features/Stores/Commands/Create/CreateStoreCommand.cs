using MediatR;

namespace ExpensesApp.Application.Features.Stores.Commands.Create
{
    public class CreateStoreCommand : IRequest<CreateStoreCommandResponse>
    {
        public string Code { get; set; }

        public string StoreName { get; set; }
    }
}
