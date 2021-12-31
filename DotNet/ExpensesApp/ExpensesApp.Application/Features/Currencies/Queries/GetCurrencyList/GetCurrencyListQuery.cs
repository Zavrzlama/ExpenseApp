using MediatR;
using System.Collections.Generic;

namespace ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyList
{
    public class GetCurrencyListQuery : IRequest<List<CurrencyListDTO>>
    {

    }
}
