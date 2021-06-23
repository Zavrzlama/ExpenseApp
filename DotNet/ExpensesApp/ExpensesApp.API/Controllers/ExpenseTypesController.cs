using Microsoft.AspNetCore.Mvc;

namespace ExpensesApp.API.Controllers
{
    [ApiController]
    [Route("ExpensesApp/ExpenseTypes")]
    public class ExpenseTypesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetExpenseTypes()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetExpenseTypeById(int id)
        {
            return Ok();
        }



    }
}
