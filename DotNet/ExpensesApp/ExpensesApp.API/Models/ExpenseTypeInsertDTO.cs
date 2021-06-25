namespace ExpensesApp.API.Models
{
    public class ExpenseTypeInsertDTO
    {
        public string Description { get; set; }
        public string ExpenseType { get; set; }
        public decimal ExpectedExpense { get; set; }
        public decimal ExpenseNotify { get; set; }
    }
}
