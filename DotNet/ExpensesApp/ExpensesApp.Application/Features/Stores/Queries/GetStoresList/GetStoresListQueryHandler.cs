using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Stores.Queries.GetStoresList
{
    public class GetStoresListQueryHandler : IRequestHandler<GetStoresListQuery, List<StoresListDTO>>
    {
        private readonly IAsyncRepository<Store> _repository;
        private readonly IMapper _mapper;

        public GetStoresListQueryHandler(IAsyncRepository<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<StoresListDTO>> Handle(GetStoresListQuery request, CancellationToken cancellationToken)
        {
            var stores = await _repository.ListAllAsync();

            return _mapper.Map<List<StoresListDTO>>(stores);
        }
    }
}