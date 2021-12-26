using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using MediatR;

namespace ExpensesApp.Application.Features.Stores.Commands.Create
{
    public class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand, CreateStoreCommandResponse>
    {
        private readonly IStoreRepository _repository;

        public CreateStoreCommandHandler(IStoreRepository repository)
        {
            _repository = repository;
        }
        public Task<CreateStoreCommandResponse> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
