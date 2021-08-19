using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Clients.Queries.GetClientList
{
    public class GetClientListQueryHandler : IRequestHandler<GetClientListQuery, List<GetClientsListDTO>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Client> _repository;

        public GetClientListQueryHandler(IMapper mapper, IAsyncRepository<Client> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<GetClientsListDTO>> Handle(GetClientListQuery request, CancellationToken cancellationToken)
        {
            var allClients = await _repository.ListAllAsync();

            return _mapper.Map<List<GetClientsListDTO>>(allClients);
        }
    }
}
