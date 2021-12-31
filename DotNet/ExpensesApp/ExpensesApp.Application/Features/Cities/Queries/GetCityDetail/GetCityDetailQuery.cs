using MediatR;

namespace ExpensesApp.Application.Features.Cities.Queries.GetCityDetail
{
    public class GetCityDetailQuery : IRequest<CityDetailDTO>
    {
        public int CityId { get; set; }
    }
}
