using MediatR;

namespace ExpensesApp.Application.Features.Currencies.Commands.Update
{
    public class UpdateCurrencyCommand : IRequest<UpdateCurrencyCommandResponse>
    {
        public int CurrencyId { get; set; }

        public string Code { get; set; }

        public string CurrencyName { get; set; }
    }
}