using MediatR;
using System.Collections.Generic;

namespace ExpensesApp.Application.Features.Stores.Queries.GetStoresList
{
    public class GetStoresListQuery: IRequest<List<StoresListDTO>>
    {

    }
}
