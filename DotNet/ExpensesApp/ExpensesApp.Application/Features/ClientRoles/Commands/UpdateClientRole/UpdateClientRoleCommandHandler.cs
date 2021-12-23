using System.IO;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole
{
    public class UpdateClientRoleCommandHandler :IRequestHandler<UpdateClientRoleCommand, UpdateClientRoleCommandResponse>
    {
        private readonly IAsyncRepository<ClientRole> _repository;
        private readonly IMapper _mapper;

        public UpdateClientRoleCommandHandler(IMapper mapper, IAsyncRepository<ClientRole> repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<UpdateClientRoleCommandResponse> Handle(UpdateClientRoleCommand request, CancellationToken cancellationToken)
        {
            var clientRole = await _repository.GetByIdAsync(request.ClientRoleId);
            var response = new UpdateClientRoleCommandResponse();

            if (clientRole != null)
                response.IsFound = true;

            if (response.IsFound)
            {
                var validator = new UpdateClientRoleCommandValidator();
                var validatorResult = await validator.ValidateAsync(request);

                if (validatorResult.Errors.Count > 0)
                {
                    response.Success = false;
                    foreach (var error in validatorResult.Errors)
                        response.ValidationErrors.Add(error.ToString());
                }

                if (response.Success)
                {
                    _mapper.Map(request, clientRole);
                    await _repository.UpdateAsync(clientRole);
                }
            }
            return response;
        }
    }
}
