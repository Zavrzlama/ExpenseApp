using MediatR;

namespace ExpensesApp.Application.Features.Clients.Commands.DeleteClient
{
    public class DeleteClientCommand : IRequest
    {
        public int ClientId { get; set; }

    }
}
