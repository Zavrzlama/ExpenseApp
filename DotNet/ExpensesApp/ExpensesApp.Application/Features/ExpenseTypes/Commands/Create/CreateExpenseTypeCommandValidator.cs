using FluentValidation;

namespace ExpensesApp.Application.Features.ExpenseTypes.Commands.Create
{
    public class CreateExpenseTypeCommandValidator : AbstractValidator<CreateExpenseTypeCommand>
    {
        public CreateExpenseTypeCommandValidator()
        {

        }
    }
}
