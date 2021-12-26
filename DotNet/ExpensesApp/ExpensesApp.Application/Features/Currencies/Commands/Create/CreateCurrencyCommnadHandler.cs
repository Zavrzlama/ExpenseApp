using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;

namespace ExpensesApp.Application.Features.Currencies.Commands.Create
{
    public class CreateCurrencyCommnadHandler : IRequestHandler<CreateCurrencyCommand,CreateCurrencyCommandResponse>
    {
        private readonly ICurrencyRepository _repository;

        public CreateCurrencyCommnadHandler(ICurrencyRepository repository)
        {
            _repository = repository;
        }

        public Task<CreateCurrencyCommandResponse> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
