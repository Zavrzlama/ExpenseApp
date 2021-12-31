using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Features.Clients.Queries.GetClientDetail;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Features.Clients.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, CreateClientCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _repository;

        public CreateClientCommandHandler(IMapper mapper, IClientRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<CreateClientCommandResponse> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateClientCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);

            var response = new CreateClientCommandResponse();

            if (validatorResult.Errors.Count > 0)
            {
                response.Success = false;

                response.ValidationErrors = new List<string>();
                foreach (var error in validatorResult.Errors)
                    response.ValidationErrors.Add(error.ErrorMessage);
            }

            if (response.Success)
            {
                var client = _mapper.Map<Client>(request);
                client = await _repository.AddAsync(client);
                response.Client = _mapper.Map<ClientDetailDTO>(client);
            }

            return response;
        }
    }
}
