using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Cities.Queries.GetCityDetail
{
    public class GetCityDetailQueryHandler : IRequestHandler<GetCityDetailQuery, CityDetailDTO>
    {
        private readonly IAsyncRepository<City> _repository;
        private readonly IMapper _mapper;

        public GetCityDetailQueryHandler(IAsyncRepository<City> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CityDetailDTO> Handle(GetCityDetailQuery request, CancellationToken cancellationToken)
        {
            var client = await _repository.GetByIdAsync(request.CityId);

            return _mapper.Map<CityDetailDTO>(client);

        }
    }
}
