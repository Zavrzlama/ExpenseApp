using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Cities.Queries.GetCityList
{
    public class GetCityListQueryHandler : IRequestHandler<GetCityListQuery, List<GetCityListDTO>>
    {
        private readonly IAsyncRepository<City> _repository;
        private readonly IMapper _mapper;

        public GetCityListQueryHandler(IAsyncRepository<City> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCityListDTO>> Handle(GetCityListQuery request, CancellationToken cancellationToken)
        {
            var cities = await _repository.ListAllAsync();

            return _mapper.Map<List<GetCityListDTO>>(cities);
        }
    }
}
