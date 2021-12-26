using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using MediatR;

namespace ExpensesApp.Application.Features.Currencies.Commands.Update
{
    public class UpdateCurrencyCommandHandler : IRequestHandler<UpdateCurrencyCommand, UpdateCurrencyCommandResponse>
    {
        private readonly ICurrencyRepository _repository;

        public UpdateCurrencyCommandHandler(ICurrencyRepository repository)
        {
            _repository = repository;
        }

        public Task<UpdateCurrencyCommandResponse> Handle(UpdateCurrencyCommand request,
            CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}