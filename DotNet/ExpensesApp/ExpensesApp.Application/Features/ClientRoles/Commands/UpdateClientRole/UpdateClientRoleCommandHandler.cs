using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole
{
    public class UpdateClientRoleCommandHandler :IRequestHandler<UpdateClientRoleCommand>
    {
        private readonly IAsyncRepository<ClientRole> _repository;
        private readonly IMapper _mapper;

        public UpdateClientRoleCommandHandler(IMapper mapper, IAsyncRepository<ClientRole> repository)
        {
            _mapper = mapper;
            _repository = repository;

        }
        public async Task<Unit> Handle(UpdateClientRoleCommand request, CancellationToken cancellationToken)
        {
            var clientRole = await _repository.GetByIdAsync(request.ClientRoleId);
            _mapper.Map(clientRole, request);

            await _repository.UpdateAsync(clientRole);

            return Unit.Value;
        }
    }
}
