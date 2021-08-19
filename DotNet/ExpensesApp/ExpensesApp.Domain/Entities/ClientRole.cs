using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExpensesApp.Domain.Common;

namespace ExpensesApp.Domain.Entities
{
    [Table("client_roles")]
    public class ClientRole : AuditEntity
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientRoleId { get; set; }
        [Column("role_name")] public string RoleName { get; set; }
        [Column("description")] public string Description { get; set; }
        public ICollection<Client> Clients;

    }
}