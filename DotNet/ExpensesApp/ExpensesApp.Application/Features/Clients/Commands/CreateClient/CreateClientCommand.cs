using MediatR;

namespace ExpensesApp.Application.Features.Clients.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<CreateClientCommandResponse>
    {
        public string ClientName { get; set; }
        public string Description { get; set; }
        public int ClientRoleId { get; set; }
    }
}
