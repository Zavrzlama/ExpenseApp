using FluentValidation;

namespace ExpensesApp.Application.Features.Cities.Commands.Create
{
    public class CreateCItyCommandValidator : AbstractValidator<CreateCityCommand>
    {
        public CreateCItyCommandValidator()
        {
            RuleFor(x => x.PostalCode).NotEmpty().NotNull();
            RuleFor(x => x.CityName).NotEmpty().NotNull();
        }
    }
}
