using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Clients.Queries.GetClientDetail
{
    public class GetClientDetailQueryHandler : IRequestHandler<GetClientDetailQuery,ClientDetailDTO>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Client> _repository;

        public GetClientDetailQueryHandler(IMapper mapper, IAsyncRepository<Client> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ClientDetailDTO> Handle(GetClientDetailQuery request, CancellationToken cancellationToken)
        {
            var client = await _repository.GetByIdAsync(request.ClientId);

            return _mapper.Map<ClientDetailDTO>(client);
        }
    }
}
