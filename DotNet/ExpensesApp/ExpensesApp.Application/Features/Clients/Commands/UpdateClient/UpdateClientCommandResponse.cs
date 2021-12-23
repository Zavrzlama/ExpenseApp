using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandResponse : BaseResponse
    {
        public bool IsFound { get; set; }
    }
}
