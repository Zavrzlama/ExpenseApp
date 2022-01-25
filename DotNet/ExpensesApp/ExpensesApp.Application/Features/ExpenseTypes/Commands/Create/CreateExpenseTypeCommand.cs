using MediatR;

namespace ExpensesApp.Application.Features.ExpenseTypes.Commands.Create
{
    public class CreateExpenseTypeCommand : IRequest<CreateExpenseTypeCommandResponse>
    {
        public string Code { get; set; }

        public string Description { get; set; }

        public string ExpenseType { get; set; }

    }
}
