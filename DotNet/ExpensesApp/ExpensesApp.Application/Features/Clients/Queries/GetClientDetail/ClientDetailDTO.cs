using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail;

namespace ExpensesApp.Application.Features.Clients.Queries.GetClientDetail
{
    public class ClientDetailDTO
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public int ClientRoleId { get; set; }
        public ClientRoleDetailDTO ClientRole { get; set; }
    }
}
