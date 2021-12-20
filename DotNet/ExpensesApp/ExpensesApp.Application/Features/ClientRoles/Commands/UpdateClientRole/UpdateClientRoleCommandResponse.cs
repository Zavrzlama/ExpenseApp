using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole
{
    public class UpdateClientRoleCommandResponse : BaseResponse
    {
        public bool IsFound { get; set; }
    }
}
