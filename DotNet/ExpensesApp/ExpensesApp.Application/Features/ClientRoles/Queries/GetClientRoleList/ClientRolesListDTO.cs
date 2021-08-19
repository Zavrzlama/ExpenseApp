using System;

namespace ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleList
{
    public class ClientRolesListDTO
    {
        public int ClientRoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
