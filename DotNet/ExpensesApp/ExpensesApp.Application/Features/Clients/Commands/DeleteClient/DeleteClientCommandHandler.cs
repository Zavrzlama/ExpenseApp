using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Clients.Commands.DeleteClient
{
    public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand>
    {
        private readonly IAsyncRepository<Client> _repository;

        public DeleteClientCommandHandler(IAsyncRepository<Client> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var client =await _repository.GetByIdAsync(request.ClientId);

            await _repository.DeleteAsync(client);

            return Unit.Value;
        }
    }
}