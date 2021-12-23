using MediatR;

namespace ExpensesApp.Application.Features.Cities.Commands.Delete
{
    public class DeleteCityCommand : IRequest
    {
        public int CityId { get; set; }
    }
}
