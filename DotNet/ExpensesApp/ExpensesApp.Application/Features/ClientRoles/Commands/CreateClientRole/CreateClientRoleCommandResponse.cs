using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail;
using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole
{
    public class CreateClientRoleCommandResponse : BaseResponse
    {
        public CreateClientRoleCommandResponse(): base()
        {

        }

        public ClientRoleDetailDTO ClientRole { get; set; }
    }
}
