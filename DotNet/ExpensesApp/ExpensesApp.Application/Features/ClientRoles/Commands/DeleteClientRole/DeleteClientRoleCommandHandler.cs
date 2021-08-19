using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.DeleteClientRole
{
    public class DeleteClientRoleCommandHandler : IRequestHandler<DeleteClientRoleCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ClientRole> _repository;

        public DeleteClientRoleCommandHandler(IMapper mapper, IAsyncRepository<ClientRole> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteClientRoleCommand request, CancellationToken cancellationToken)
        {
            var clientRole = await _repository.GetByIdAsync(request.ClientRole);

            await _repository.DeleteAsync(clientRole);

            return Unit.Value;
        }
    }
}
