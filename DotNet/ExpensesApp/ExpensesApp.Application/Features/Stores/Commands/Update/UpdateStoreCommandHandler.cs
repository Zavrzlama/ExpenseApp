using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.Stores.Commands.Update
{
    public class UpdateStoreCommandHandler : IRequestHandler<UpdateStoreCommand, UpdateStoreCommandResponse>
    {
        private readonly IStoreRepository _repository;
        private readonly IMapper _mapper;

        public UpdateStoreCommandHandler(IStoreRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<UpdateStoreCommandResponse> Handle(UpdateStoreCommand request, CancellationToken cancellationToken)
        {
            var response = new UpdateStoreCommandResponse();
            var store = await _repository.GetByIdAsync(request.StoreId);

            if (store == null)
                response.StoreExists = false;

            if (response.StoreExists)
            {
                var validator = new UpdateStoreCommandValidator();
                var validatorResult = await validator.ValidateAsync(request);

                if (validatorResult.Errors.Count > 0)
                {
                    response.Success = false;
                    response.ValidationErrors = new List<string>();
                    foreach (var error in validatorResult.Errors)
                        response.ValidationErrors.Add(error.ErrorMessage);
                }
            }

            if (response.Success)
            {
                _mapper.Map(store, request);
                await _repository.UpdateAsync(store);
            }

            return response;
        }
    }
}
