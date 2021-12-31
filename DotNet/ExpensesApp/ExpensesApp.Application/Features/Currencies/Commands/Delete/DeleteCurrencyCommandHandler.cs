using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Currencies.Commands.Delete
{
    public class DeleteCurrencyCommandHandler : IRequestHandler<DeleteCurrencyCommand>
    {
        private readonly IAsyncRepository<Currency> _repository;

        public DeleteCurrencyCommandHandler(IAsyncRepository<Currency> repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteCurrencyCommand request, CancellationToken cancellationToken)
        {
            var currency = await _repository.GetByIdAsync(request.CurrencyId);

            if (currency != null)
                await _repository.DeleteAsync(currency);

            return Unit.Value;
        }
    }
}
