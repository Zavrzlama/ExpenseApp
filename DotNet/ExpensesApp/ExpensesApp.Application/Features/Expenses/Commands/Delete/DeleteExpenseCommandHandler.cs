using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Expenses.Commands.Delete
{
    public class DeleteExpenseCommandHandler : IRequestHandler<DeleteExpenseCommand>
    {
        private readonly IAsyncRepository<Expense> _repository;

        public DeleteExpenseCommandHandler(IAsyncRepository<Expense> repository)
        {
            _repository = repository;
        }
        public Task<Unit> Handle(DeleteExpenseCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
