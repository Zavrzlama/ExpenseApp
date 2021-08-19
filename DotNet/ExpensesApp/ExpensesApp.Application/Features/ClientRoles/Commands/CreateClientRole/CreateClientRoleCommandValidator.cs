using FluentValidation;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole
{
    public class CreateClientRoleCommandValidator : AbstractValidator<CreateClientRoleCommand>
    {
        public CreateClientRoleCommandValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("{Property name} is required").NotNull();
        }
    }
}