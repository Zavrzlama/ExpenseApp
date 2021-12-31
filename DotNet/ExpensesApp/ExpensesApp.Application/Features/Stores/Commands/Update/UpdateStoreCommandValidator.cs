using FluentValidation;

namespace ExpensesApp.Application.Features.Stores.Commands.Update
{
    public class UpdateStoreCommandValidator : AbstractValidator<UpdateStoreCommand>
    {
        public UpdateStoreCommandValidator()
        {
            RuleFor(x => x.Code).NotNull().NotEmpty();
            RuleFor(x => x.StoreName).NotNull().NotEmpty();
        }
    }
}
