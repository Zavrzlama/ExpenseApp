using ExpensesApp.Application.Features.Cities.Queries.GetCityDetail;
using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.Cities.Commands.Create
{
    public class CreateCityCommandResponse : BaseResponse
    {

        public CreateCityCommandResponse() : base()
        {
        }

        public CityDetailDTO City { get; set; }
    }
}
