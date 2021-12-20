using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("currencies")]
    public class Currency
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("code")] public string Code { get; set; }

        [Column("currency_name")] public string CurrencyName { get; set; }
    }
}