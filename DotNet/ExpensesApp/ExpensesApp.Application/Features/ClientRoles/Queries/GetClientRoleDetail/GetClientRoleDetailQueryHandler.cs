using MediatR;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail
{
    public class GetClientRoleDetailQueryHandler : IRequestHandler<GetClientRolesDetailQuery, ClientRoleDetailDTO>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ClientRole> _repository;

        public GetClientRoleDetailQueryHandler(IMapper mapper, IAsyncRepository<ClientRole> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ClientRoleDetailDTO> Handle(GetClientRolesDetailQuery request, CancellationToken cancellationToken)
        {
            var clientRole = await _repository.GetByIdAsync(request.Id);

            return _mapper.Map<ClientRoleDetailDTO>(clientRole);
        }
    }
}