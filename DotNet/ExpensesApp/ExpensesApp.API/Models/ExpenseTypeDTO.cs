namespace ExpensesApp.API.Models
{
    public class ExpenseTypeDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string ExpenseType { get; set; }
        public decimal ExpectedExpense { get; set; }
        public decimal ExpenseNotify { get; set; }
    }
}
