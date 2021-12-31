using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Stores.Queries.GetStoreDetail
{
    public class GetStoreDetailQueryHandler : IRequestHandler<GetStoreDetailQuery, StoreDetailDTO>
    {

        private readonly IAsyncRepository<Store> _repository;
        private readonly IMapper _mapper;

        public GetStoreDetailQueryHandler(IAsyncRepository<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StoreDetailDTO> Handle(GetStoreDetailQuery request, CancellationToken cancellationToken)
        {
            var store = await _repository.GetByIdAsync(request.StoreId);

            return _mapper.Map<StoreDetailDTO>(store);
        }
    }
}
