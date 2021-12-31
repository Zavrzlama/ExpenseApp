using MediatR;

namespace ExpensesApp.Application.Features.Currencies.Commands.Create
{
    public class CreateCurrencyCommand : IRequest<CreateCurrencyCommandResponse>
    {

        public string Code { get; set; }

        public string  CurrencyName { get; set; }
        
    }
}
