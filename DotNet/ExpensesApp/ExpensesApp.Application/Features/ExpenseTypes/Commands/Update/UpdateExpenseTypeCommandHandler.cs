using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.ExpenseTypes.Commands.Update
{
    public class UpdateExpenseTypeCommandHandler : IRequestHandler<UpdateExpenseTypeCommand, UpdateExpenseTypeResponse>
    {


        public Task<UpdateExpenseTypeResponse> Handle(UpdateExpenseTypeCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
