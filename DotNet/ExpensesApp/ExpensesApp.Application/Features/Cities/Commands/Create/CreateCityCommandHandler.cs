using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Application.Features.Cities.Queries.GetCityDetail;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Cities.Commands.Create
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CreateCityCommandResponse>
    {
        private readonly IAsyncRepository<City> _repository;
        private readonly IMapper _mapper;

        public CreateCityCommandHandler(IAsyncRepository<City> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateCityCommandResponse> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateCityCommandResponse();
            var validator = new CreateCItyCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            if (validatorResult.Errors.Count > 0)
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();

                foreach (var error in validatorResult.Errors)
                    response.ValidationErrors.Add(error.ErrorMessage);
            }

            if (response.Success)
            {
                var city = _mapper.Map<City>(request);
                city = await _repository.AddAsync(city);

                response.City = _mapper.Map<CityDetailDTO>(city);
            }

            return response;
        }
    }
}
