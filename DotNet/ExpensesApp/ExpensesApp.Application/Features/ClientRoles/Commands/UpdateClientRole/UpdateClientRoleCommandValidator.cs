using FluentValidation;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole
{
    public class UpdateClientRoleCommandValidator : AbstractValidator<UpdateClientRoleCommand>
    {

        public UpdateClientRoleCommandValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("Code is required").NotNull();
            RuleFor(x=> x.RoleName).NotEmpty().WithMessage("Role name is required");
        }
    }
}
