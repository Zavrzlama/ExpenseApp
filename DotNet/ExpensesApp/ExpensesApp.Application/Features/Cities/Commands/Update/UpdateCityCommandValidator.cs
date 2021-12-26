using FluentValidation;

namespace ExpensesApp.Application.Features.Cities.Commands.Update
{
    public class UpdateCityCommandValidator : AbstractValidator<UpdateCityCommand>
    {
        public UpdateCityCommandValidator()
        {
            RuleFor(x => x.PostalCode).NotEmpty().NotNull();
            RuleFor(x => x.PostalCode).NotEmpty().NotNull();
        }
    }
}
