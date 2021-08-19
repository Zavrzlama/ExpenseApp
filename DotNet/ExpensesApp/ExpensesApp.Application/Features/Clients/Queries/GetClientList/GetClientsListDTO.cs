using System;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail;

namespace ExpensesApp.Application.Features.Clients.Queries.GetClientList
{
    public class GetClientsListDTO
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int ClientRoleId { get; set; }
        public ClientRoleDetailDTO ClientRole { get; set; }
    }
}
