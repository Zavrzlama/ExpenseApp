using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("expenses")]
    public class Expense
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("description")] public string Description { get; set; }

        [Column("amount")] public decimal Amount { get; set; }

        [Column("expense_date")] public DateTime ExpenseDate { get; set; }

        [ForeignKey("store_id")]
        [Column("store_id")]
        public int StoreId { get; set; }

        public Store Store { get; set; }

        [ForeignKey("city_id")]
        [Column("city_id")]
        public int CityId { get; set; }

        public City City { get; set; }

        [ForeignKey("expense_type_id")]
        [Column("expense_type_id")]
        public int ExpenseTypeId { get; set; }

        public ExpenseType ExpenseType { get; set; }

        [Column("date_created")] public DateTime DateCreated { get; set; }

        [Column("date_updated")] public DateTime DateUpdated { get; set; }

        [Column("user_created")] public int UserInserted { get; set; }

        [Column("user_updated")] public int UserUpdated { get; set; }
    }
}
