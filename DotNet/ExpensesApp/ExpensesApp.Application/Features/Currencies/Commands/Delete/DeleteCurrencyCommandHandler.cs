using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using MediatR;

namespace ExpensesApp.Application.Features.Currencies.Commands.Delete
{
    public class DeleteCurrencyCommandHandler : IRequestHandler<DeleteCurrencyCommand>
    {
        private readonly ICurrencyRepository _repository;

        public DeleteCurrencyCommandHandler(ICurrencyRepository repository)
        {
            _repository = repository;
        }
        public Task<Unit> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
