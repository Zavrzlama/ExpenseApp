using System.Collections.Generic;
using ExpensesApp.API.Entities;

namespace ExpensesApp.API.Services
{
    public interface IExpenseTypesRepository
    {
        IEnumerable<ExpenseType> GetExpenseTypes();

        ExpenseType GetExpenseType(int id);

        bool ExpenseTypeExists(int id);

        void AddExpenseType(ExpenseType expenseType);

        void DeleteExpenseTYpe(ExpenseType expenseType);

        bool Save();
    }
}