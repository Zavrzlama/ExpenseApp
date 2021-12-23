using System.Data;
using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using FluentValidation;

namespace ExpensesApp.Application.Features.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandValidator : AbstractValidator<UpdateClientCommand>
    {
        private readonly IClientRolesRepository _repository;

        public UpdateClientCommandValidator(IClientRolesRepository repository)
        {
            _repository = repository;
            RuleFor(x => x.ClientName).NotEmpty().NotNull();
            RuleFor(x => x.ClientSurname).NotEmpty().NotNull();
            RuleFor(e => e).MustAsync(ClientRoleExists).WithMessage("Client role not exists");
        }


        public async Task<bool> ClientRoleExists(UpdateClientCommand command, CancellationToken token)
        {
            return await _repository.ClientRoleWithIdExists(command.ClientId);
        }

    }
}
