using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyList
{
    public class GetCurrencyListQueryHandler : IRequestHandler<GetCurrencyListQuery, List<CurrencyListDTO>>
    {
        private readonly IAsyncRepository<Currency> _repository;
        private readonly IMapper _mapper;

        public GetCurrencyListQueryHandler(IAsyncRepository<Currency> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<CurrencyListDTO>> Handle(GetCurrencyListQuery request, CancellationToken cancellationToken)
        {
            var currencies = await _repository.ListAllAsync();

            return _mapper.Map<List<CurrencyListDTO>>(currencies);
        }
    }
}
