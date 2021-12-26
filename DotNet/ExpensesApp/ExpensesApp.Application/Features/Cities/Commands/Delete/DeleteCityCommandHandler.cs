using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Features.Cities.Commands.Delete
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand>
    {
        private readonly IAsyncRepository<City> _repository;

        public DeleteCityCommandHandler(IAsyncRepository<City> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            var city = await _repository.GetByIdAsync(request.CityId);

            if (city != null)
                await _repository.DeleteAsync(city);

            return Unit.Value;
        }
    }
}
