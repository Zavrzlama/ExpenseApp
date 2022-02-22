using AutoMapper;
using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Application.Features.ExpenseTypes.Queries.GetClientList;
using ExpensesApp.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Features.ExpenseTypes.Queries.GetExpenseTypeList
{
    public class GetExpenseTypeListQueryHandler : IRequestHandler<GetExpenseTypeListQuery, List<ExpenseTypeListDTO>>
    {
        private readonly IAsyncRepository<ExpenseType> _repository;
        private readonly IMapper _mapper;

        public GetExpenseTypeListQueryHandler(IAsyncRepository<ExpenseType> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ExpenseTypeListDTO>> Handle(GetExpenseTypeListQuery request, CancellationToken cancellationToken)
        {
            var expenseTypes = await _repository.ListAllAsync();

            return _mapper.Map<List<ExpenseTypeListDTO>>(expenseTypes);
        }
    }
}
