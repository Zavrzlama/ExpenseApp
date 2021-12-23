using MediatR;

namespace ExpensesApp.Application.Features.Cities.Commands.Create
{
    public class CreateCityCommand : IRequest
    {
        public string PostalCode { get; set; }
        public string CityName { get; set; }
    }
}
