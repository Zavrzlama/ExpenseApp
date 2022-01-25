using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.ExpenseTypes.Commands.Create
{
    public class CreateExpenseTypeCommandHandler : IRequestHandler<CreateExpenseTypeCommand,CreateExpenseTypeCommandResponse>
    {
        private readonly IAsyncRepository<ExpenseType> _repository;
        private readonly IMapper _mapper;

        public CreateExpenseTypeCommandHandler(IAsyncRepository<ExpenseType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task<CreateExpenseTypeCommandResponse> Handle(CreateExpenseTypeCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
