using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole
{
    public class CreateClientRoleCommandHandler : IRequestHandler<CreateClientRoleCommand, CreateClientRoleCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IClientRolesRepository _repository;

        public CreateClientRoleCommandHandler(IMapper mapper, IClientRolesRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<CreateClientRoleCommandResponse> Handle(CreateClientRoleCommand request, CancellationToken cancellationToken)
        {
            var createClientRoleCommandResponse = new CreateClientRoleCommandResponse();

            var validator = new CreateClientRoleCommandValidator(_repository);
            var validatorResult = await validator.ValidateAsync(request);

            if (validatorResult.Errors.Count > 0)
            {
                createClientRoleCommandResponse.Success = false;
                createClientRoleCommandResponse.ValidationErrors = new List<string>();

                foreach (var error in validatorResult.Errors)
                    createClientRoleCommandResponse.ValidationErrors.Add(error.ErrorMessage);
            }

            if (createClientRoleCommandResponse.Success)
            {
                var clientRole = new ClientRole() { RoleName = request.RoleName, Description = request.Description, Code = request.Code};
                clientRole = await _repository.AddAsync(clientRole);
                createClientRoleCommandResponse.ClientRole = _mapper.Map<ClientRoleDetailDTO>(clientRole);
            }

            return createClientRoleCommandResponse;
        }
    }
}
