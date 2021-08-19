using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExpensesApp.Domain.Common;

namespace ExpensesApp.Domain.Entities
{
    public class Client : AuditEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ClientId { get; set; }
        [Column("client_name")] [Required] public string ClientName { get; set; }
        [Column("description")] public string Description { get; set; }
        [ForeignKey("client_role_id")] public int ClientRoleID { get; set; }
        public ClientRole ClientRole { get; set; }
    }
}