using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.API.Entities
{
    public class Client
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ClientId { get; set; }
        [Column("client_name")] [Required] public string ClientName { get; set; }
        [Column("description")] public string Description { get; set; }
        [Column("date_created")] public DateTime DateCreated { get; set; }
        [Column("date_updated")] public DateTime DateUpdated { get; set; }
        [ForeignKey("client_role_id")] public int ClientRoleID { get; set; }
        public ClientRole ClientRole { get; set; }
    }
}