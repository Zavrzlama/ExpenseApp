using ExpensesApp.Application.Features.ExpenseTypes.Queries.GetClientList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExpensesApp.Api.Controllers
{
    public class ExpenseTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ExpenseTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllexpenseTypes")]
        public async Task<ActionResult<ExpenseTypeListDTO>> GetAllExpenseTypes()
        {
            var response = new 
        }

    }
}
