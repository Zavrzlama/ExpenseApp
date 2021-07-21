using System;

namespace ExpensesApp.API.Models
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string ClientNane { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public ClientRoleDTO ClientRoleDto { get; set; }
    }
}