using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Stores.Commands.Delete
{
    public class DeleteStoreCommandHandler : IRequestHandler<DeleteStoreCommand>
    {
        private readonly IAsyncRepository<Store> _repository;

        public DeleteStoreCommandHandler(IAsyncRepository<Store> repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
        {
            var store = await _repository.GetByIdAsync(request.StoreId);

            if (store != null)
                await _repository.DeleteAsync(store);

            return Unit.Value;
        }
    }
}