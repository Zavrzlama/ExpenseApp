using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("cities")]
    public class City
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("postal_code")] public string PostalCode { get; set; }
        [Column("city_name")] public string CityName { get; set; }

    }
}