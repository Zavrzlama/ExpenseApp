using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("stores")]
    public class Store
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("code")] public string Code { get; set; }

        [Column("store_name")] public string StoreName { get; set; }

    }
}
