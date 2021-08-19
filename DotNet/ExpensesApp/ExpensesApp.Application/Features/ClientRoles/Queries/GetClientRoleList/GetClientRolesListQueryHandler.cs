using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleList
{
    public class GetClientRolesListQueryHandler : IRequestHandler<GetClientRolesListQuery, List<ClientRolesListDTO>>
    {
        private IMapper _mapper;
        private IAsyncRepository<ClientRole> _repository;

        public GetClientRolesListQueryHandler(IMapper mapper, IAsyncRepository<ClientRole> repository)
        {
            _mapper = mapper ?? throw new ArgumentException(nameof(mapper));
            _repository = repository ?? throw new ArgumentException(nameof(repository));
        }
        public async Task<List<ClientRolesListDTO>> Handle(GetClientRolesListQuery request, CancellationToken cancellationToken)
        {
            var allClientRoles = await _repository.ListAllAsync();
            return _mapper.Map<List<ClientRolesListDTO>>(allClientRoles);
        }
    }
}
