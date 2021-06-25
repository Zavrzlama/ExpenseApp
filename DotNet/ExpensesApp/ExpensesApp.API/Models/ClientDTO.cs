namespace ExpensesApp.API.Models
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string ClientNane { get; set; }
        public string Description { get; set; }
        public ClientRoleDTO ClientRoleDto { get; set; }
    }
}