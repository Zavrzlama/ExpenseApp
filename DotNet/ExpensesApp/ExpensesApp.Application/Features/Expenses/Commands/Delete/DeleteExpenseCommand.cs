using MediatR;

namespace ExpensesApp.Application.Features.Expenses.Commands.Delete
{
    public class DeleteExpenseCommand : IRequest
    {
        public int ExpenseId { get; set; }
    }
}
