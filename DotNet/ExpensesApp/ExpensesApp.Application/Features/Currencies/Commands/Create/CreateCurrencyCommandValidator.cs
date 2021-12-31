using ExpensesApp.Application.Contracts.Persistence;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Currencies.Commands.Create
{
    public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
    {
        private readonly ICurrencyRepository _repository;

        public CreateCurrencyCommandValidator(ICurrencyRepository repository)
        {
            _repository = repository;

            RuleFor(x => x.Code).NotEmpty().NotNull();
            RuleFor(x => x.CurrencyName).NotEmpty().NotNull();
            RuleFor(e => e).MustAsync(CurrencyWithCodeExists).WithMessage("Currency with same code exists");
        }

        private async Task<bool> CurrencyWithCodeExists(CreateCurrencyCommand command, CancellationToken token)
        {
            return !await _repository.CurrencyWithCodeExists(command.Code);
        }
    }
}