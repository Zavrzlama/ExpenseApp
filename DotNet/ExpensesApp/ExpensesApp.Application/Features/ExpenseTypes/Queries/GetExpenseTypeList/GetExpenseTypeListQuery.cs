using MediatR;
using System.Collections.Generic;

namespace ExpensesApp.Application.Features.ExpenseTypes.Queries.GetClientList
{
    public class GetExpenseTypeListQuery : IRequest<List<ExpenseTypeListDTO>>
    {

    }
}
