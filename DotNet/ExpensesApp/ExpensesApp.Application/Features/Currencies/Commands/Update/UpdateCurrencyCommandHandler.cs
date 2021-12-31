using System.Collections.Generic;
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

        public async Task<UpdateCurrencyCommandResponse> Handle(UpdateCurrencyCommand request,
            CancellationToken cancellationToken)
        {
            var response = new UpdateCurrencyCommandResponse();

            var currency = await _repository.GetByIdAsync(request.CurrencyId);

            if (currency == null)
                response.CurrencyExists = false;

            if (response.CurrencyExists)
            {
                var validator = new UpdateCurrencyCommandValidator();
                var validatorResult = await validator.ValidateAsync(request);

                if (validatorResult.Errors.Count > 0)
                {
                    response.Success = false;
                    response.ValidationErrors = new List<string>();

                    foreach (var error in validatorResult.Errors)
                        response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            return response;
        }
    }
}