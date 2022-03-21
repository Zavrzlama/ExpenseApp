namespace ExpensesApp.Application.Models
{
    public class ImportModel
    {
        public string ExpenseDate { get; set; }
        public double Amount { get; set; }
        public string Account { get; set; }
        public string Description { get; set; }
    }
}
