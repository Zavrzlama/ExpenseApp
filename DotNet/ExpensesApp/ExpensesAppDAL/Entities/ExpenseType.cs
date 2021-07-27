using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesAppDAL.Entities { 
    [Table("expense_types")]
    public class ExpenseType
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ExpenseTypeID { get; set; }
        [Column("description")] public string Description { get; set; }
        [Column("expense_type")] public string IncomeOutcome { get; set; }
        [Column("expected_expense")] public decimal ExpectedExpense { get; set; }
        [Column("expense_notify")] public decimal ExpenseNotify { get; set; }
        [Column("date_created")] public DateTime DateCreated { get; set; }
        [Column("date_updated")] public DateTime DateUpdated { get; set; }
    }
}