using FluentValidation;

namespace ExpensesApp.Application.Features.Currencies.Commands.Update
{
    public class UpdateCurrencyCommandValidator : AbstractValidator<UpdateCurrencyCommand>
    {
        public UpdateCurrencyCommandValidator()
        {
        }
    }
}
