using System.Threading;
using System.Threading.Tasks;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;

namespace ExpensesApp.Application.Features.Expenses.Commands.Create
{
    public class CreateExpenseCommandHandler : IRequestHandler<CreateExpenseCommand,CreateExpenseCommandResponse>
    {
        private readonly IAsyncRepository<Expense> _repository;

        public CreateExpenseCommandHandler(IAsyncRepository<Expense> repository)
        {
            _repository = repository;
        }

        public Task<CreateExpenseCommandResponse> Handle(CreateExpenseCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
