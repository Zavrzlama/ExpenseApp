using FluentValidation;

namespace ExpensesApp.Application.Features.Clients.Commands.CreateClient
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(x => x.ClientName).NotNull().NotEmpty();
            RuleFor(x => x.ClientRoleId).NotNull().NotEmpty();
        }
    }
}
