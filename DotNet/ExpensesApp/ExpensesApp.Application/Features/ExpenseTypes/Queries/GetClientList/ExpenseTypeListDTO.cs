namespace ExpensesApp.Application.Features.ExpenseTypes.Queries.GetClientList
{
    public class ExpenseTypeListDTO
    {
        public int ExpenseTypeId { get; set; }
    
        public string Code { get; set; }

        public string ExpenseType { get; set; }

        public string Description { get; set; }
    }
}
