using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Entities
{
    [Table("client_roles")]
    public class ClientRole
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientRoleId { get; set; }

        [Column("role_name")] public string RoleName { get; set; }

        [Column("code")] public string Code { get; set; }

        [Column("description")] public string Description { get; set; }

        [Column("date_created")] public DateTime DateCreated { get; set; }

        [Column("date_updated")] public DateTime DateUpdated { get; set; }

        [Column("user_created")] public int UserInserted { get; set; }

        [Column("user_updated")] public int UserUpdated { get; set; }

        public ICollection<Client> Clients;

    }
}