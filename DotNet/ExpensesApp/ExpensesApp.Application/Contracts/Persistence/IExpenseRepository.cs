using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Contracts.Persistence
{
    public interface IExpenseRepository : IAsyncRepository<Expense>
    {

    }
}
