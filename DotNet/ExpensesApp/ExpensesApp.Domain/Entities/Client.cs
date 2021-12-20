using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("clients")]
    public class Client
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ClientId { get; set; }

        [Column("code")] public string Code { get; set; }

        [Column("client_name")] public string ClientName { get; set; }

        [Column("client_surname")] public string ClientSurname { get; set; }

        [Column("description")] public string Description { get; set; }

        [Column("date_created")] public DateTime DateCreated { get; set; }

        [Column("date_updated")] public DateTime DateUpdated { get; set; }

        [Column("user_created")] public int UserInserted { get; set; }

        [Column("user_updated")] public int UserUpdated { get; set; }

        [ForeignKey("client_role_id")]
        [Column("client_role_id")]
        public int ClientRoleId { get; set; }

        public ClientRole ClientRole { get; set; }
    }
}