using System.Collections.Generic;
using MediatR;

namespace ExpensesApp.Application.Features.Cities.Queries.GetCityList
{
    public class GetCityListQuery : IRequest<List<CityListDTO>>
    {

    }
}
