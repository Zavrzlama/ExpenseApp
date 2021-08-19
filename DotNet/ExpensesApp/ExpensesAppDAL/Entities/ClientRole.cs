﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesAppDAL.Entities
{
    [Table("client_roles")]
    public class ClientRole
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ClientRoleId { get; set; }
        [Column("role_name")] [Required] public string RoleName { get; set; }
        [Column("description")] public string Description { get; set; }
        [Column("date_created")]public DateTime DateCreated { get; set; }
        [Column("date_updated")] public DateTime DateUpdated { get; set; }
    }
}