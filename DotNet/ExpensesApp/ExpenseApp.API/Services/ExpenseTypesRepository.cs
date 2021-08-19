using System;
using System.Collections.Generic;
using System.Linq;
using ExpensesApp.API.DBContexts;
using ExpensesApp.API.Entities;

namespace ExpensesApp.API.Services
{
    public class ExpenseTypesRepository : IExpenseTypesRepository
    {
        private readonly ExpenseAppContext _dbContext;

        public ExpenseTypesRepository(ExpenseAppContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IEnumerable<ExpenseType> GetExpenseTypes()
        {
            return _dbContext.ExpenseTypes.ToList();
        }

        public ExpenseType GetExpenseType(int id)
        {
            return _dbContext.ExpenseTypes.FirstOrDefault(x => x.ExpenseTypeID == id);
        }

        public bool ExpenseTypeExists(int id)
        {
            return _dbContext.ExpenseTypes.Any(x => x.ExpenseTypeID == id);
        }

        public void AddExpenseType(ExpenseType expenseType)
        {
            _dbContext.ExpenseTypes.Add(expenseType);
        }

        public void DeleteExpenseTYpe(ExpenseType expenseType)
        {
            _dbContext.ExpenseTypes.Remove(expenseType);
        }

        public bool Save()
        {
            return _dbContext.SaveChanges() >= 0;
        }
    }
}