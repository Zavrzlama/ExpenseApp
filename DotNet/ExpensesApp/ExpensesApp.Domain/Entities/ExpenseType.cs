using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("expense_types")]
    public class ExpenseType
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ExpenseTypeID { get; set; }

        [Column("description")] public string Description { get; set; }

        [Column("code")] public string Code { get; set; }

        [Column("expense_type")] public string IncomeOutcome { get; set; }

        [Column("date_created")] public DateTime DateCreated { get; set; }

        [Column("date_updated")] public DateTime DateUpdated { get; set; }

        [Column("user_created")] public int UserInserted { get; set; }

        [Column("user_updated")] public int UserUpdated { get; set; }

        [Column("expected_expense")] public decimal ExpectedExpense { get; set; }

        [Column("expense_notify")] public decimal ExpenseNotify { get; set; }
    }
}