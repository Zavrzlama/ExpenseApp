using ExpensesApp.Application.Features.Clients.Queries.GetClientDetail;
using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.Clients.Commands.CreateClient
{
    public class CreateClientCommandResponse : BaseResponse
    {
        public CreateClientCommandResponse():base()
        {
            
        }

        public  ClientDetailDTO Client { get; set; }
    }
}
