using ExpensesApp.Application.Contracts.Persistence;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;

namespace ExpensesApp.Application.Features.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, UpdateClientCommandResponse>
    {
        private readonly IClientRepository _repository;
        private readonly IClientRolesRepository _rolesRepository;
        private readonly IMapper _mapper;

        public UpdateClientCommandHandler(IClientRepository repository, IClientRolesRepository rolesRepository, IMapper mapper)
        {
            _repository = repository;
            _rolesRepository = rolesRepository;
            _mapper = mapper;
        }

        public async Task<UpdateClientCommandResponse> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var client = await _repository.GetByIdAsync(request.ClientId);
            var response = new UpdateClientCommandResponse();

            if (client == null)
                response.IsFound = false;

            if (response.IsFound)
            {
                var validator = new UpdateClientCommandValidator(_rolesRepository);
                var validate = validator.ValidateAsync(request);

                if (validate.Result.Errors.Count >0 )
                {
                    response.Success = false;
                    foreach (var error in validate.Result.Errors)
                        response.ValidationErrors.Add(error.ToString());
                }

                if (response.Success)
                {
                    _mapper.Map(client, request);
                    await _repository.UpdateAsync(client);
                }
            }

            return response;
        }
    }
}
