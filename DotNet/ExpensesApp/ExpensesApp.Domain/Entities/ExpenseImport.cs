using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("document_import")]
    public class ExpenseImport
    {
        [Column("expense_date")]
        DateTime ExpenseDate { get; set; }
        [Column("clientName")]
        string ClientName { get; set; }
        [Column("description")]
        string Description { get; set; }
        [Column("amount")]
        double Amount { get; set; }
    }
}
