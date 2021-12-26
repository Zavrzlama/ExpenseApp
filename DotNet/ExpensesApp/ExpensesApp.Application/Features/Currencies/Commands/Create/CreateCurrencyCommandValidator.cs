using FluentValidation;

namespace ExpensesApp.Application.Features.Currencies.Commands.Create
{
    public class CreateCurrencyCommandValidator : AbstractValidator<CreateCurrencyCommand>
    {
        public CreateCurrencyCommandValidator()
        {
        }
    }
}