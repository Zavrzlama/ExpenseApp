using FluentValidation;

namespace ExpensesApp.Application.Features.Stores.Commands.Create
{
    public class CreateStoreCommandValidator : AbstractValidator<CreateStoreCommand>
    {
        public CreateStoreCommandValidator()
        {
            RuleFor(x => x.Code).NotNull().NotEmpty();
            RuleFor(x => x.StoreName).NotNull().NotEmpty();
        }
    }
}
