using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyDetail
{
    public class GetCurrencyDetailQueryHandler : IRequestHandler<GetCurrencyDetailQuerey, CurrencyDetailDTO>
    {
        private readonly IAsyncRepository<Currency> _repository;
        private readonly IMapper _mapper;

        public GetCurrencyDetailQueryHandler(IAsyncRepository<Currency> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CurrencyDetailDTO> Handle(GetCurrencyDetailQuerey request, CancellationToken cancellationToken)
        {
            var currency = await _repository.GetByIdAsync(request.CurrencyId);

            return _mapper.Map<CurrencyDetailDTO>(currency);
        }
    }
}
