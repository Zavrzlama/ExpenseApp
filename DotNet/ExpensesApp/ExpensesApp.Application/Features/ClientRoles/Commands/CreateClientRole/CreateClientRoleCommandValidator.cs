using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using FluentValidation;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole
{
    public class CreateClientRoleCommandValidator : AbstractValidator<CreateClientRoleCommand>
    {
        private readonly IClientRolesRepository _repository;

        public CreateClientRoleCommandValidator(IClientRolesRepository _repository)
        {
            this._repository = _repository;

            RuleFor(x => x.RoleName).NotEmpty().NotNull();
            RuleFor(x => x.Code).NotEmpty().NotNull();
            RuleFor(e => e).MustAsync(ClientRoleExists).WithMessage("Client role with same code exists");
        }

        private async Task<bool> ClientRoleExists(CreateClientRoleCommand command, CancellationToken token)
        {
            return !await _repository.ClientRoleWithCodeExists(command.Code);
        }
    }
}