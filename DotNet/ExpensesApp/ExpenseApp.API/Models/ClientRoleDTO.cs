using System;

namespace ExpensesApp.API.Models
{
    public class ClientRoleDTO
    {
        public int ClientRoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
