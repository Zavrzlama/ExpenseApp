﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.API.Entities
{
    [Table("expense_types")]
    public class ExpenseType
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ExpenseTypeID { get; set; }

        [Column("description")] [Required] public string Dwscription { get; set; }

        [Column("expense_type")] [Required] public string IncomeOutcome { get; set; }

        [Column("expected_expense")] public decimal ExpectedExpense { get; set; }

        [Column("expense_notify")] public decimal ExpenseNotify { get; set; }
    }
}