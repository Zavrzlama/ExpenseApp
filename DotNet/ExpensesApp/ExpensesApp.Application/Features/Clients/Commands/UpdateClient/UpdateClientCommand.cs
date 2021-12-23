using MediatR;

namespace ExpensesApp.Application.Features.Clients.Commands.UpdateClient
{
    public class UpdateClientCommand : IRequest<UpdateClientCommandResponse>
    {
        public int ClientId { get; set; }
        public string Code { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientEmail { get; set; }
        public string Description { get; set; }
    }
}