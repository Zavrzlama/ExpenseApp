using MediatR;

namespace ExpensesApp.Application.Features.Cities.Commands.Update
{
    public class UpdateCityCommand : IRequest<UpdateCityCommandResponse>
    {
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string CityName { get; set; }
    }
}
