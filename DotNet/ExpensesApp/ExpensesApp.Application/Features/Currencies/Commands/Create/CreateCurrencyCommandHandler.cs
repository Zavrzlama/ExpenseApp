using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using System.Collections.Generic;
using AutoMapper;
using ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyDetail;

namespace ExpensesApp.Application.Features.Currencies.Commands.Create
{
    public class CreateCurrencyCommandHandler : IRequestHandler<CreateCurrencyCommand,CreateCurrencyCommandResponse>
    {
        private readonly ICurrencyRepository _repository;
        private readonly IMapper _mapper;

        public CreateCurrencyCommandHandler(ICurrencyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateCurrencyCommandResponse> Handle(CreateCurrencyCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateCurrencyCommandResponse();

            var validator = new CreateCurrencyCommandValidator(_repository);
            var validateResult = await validator.ValidateAsync(request);

            if (validateResult.Errors.Count > 0) {
                response.Success = false;
                response.ValidationErrors = new List<string>();

                foreach (var error in validateResult.Errors)    
                    response.ValidationErrors.Add(error.ErrorMessage);
            }

            if (response.Success)
            {
                var currency = _mapper.Map<Currency>(request);
                currency = await _repository.AddAsync(currency);
                response.Currency = _mapper.Map<CurrencyDetailDTO>(currency);
            }

            return response;
        }
    }
}
