using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Application.Features.Stores.Queries.GetStoreDetail;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Stores.Commands.Create
{
    public class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand, CreateStoreCommandResponse>
    {
        private readonly IAsyncRepository<Store> _repository;
        private readonly IMapper _mapper;

        public CreateStoreCommandHandler(IAsyncRepository<Store> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CreateStoreCommandResponse> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            var response = new CreateStoreCommandResponse();
            var validator = new CreateStoreCommandValidator();
            var validatorResult = await validator.ValidateAsync(request, cancellationToken);

            if (validatorResult.Errors.Count > 0)
            {
                response.Success = false;
                response.ValidationErrors = new List<string>();

                foreach (var error in validatorResult.Errors)
                    response.ValidationErrors.Add(error.ErrorMessage);
            }

            if (response.Success)
            {
                var store = _mapper.Map<Store>(response);
                store = await _repository.AddAsync(store);

                response.Store = _mapper.Map<StoreDetailDTO>(store);
            }

            return response;
        }
    }
}
