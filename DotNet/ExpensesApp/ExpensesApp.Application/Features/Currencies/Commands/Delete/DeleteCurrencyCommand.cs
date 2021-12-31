using MediatR;

namespace ExpensesApp.Application.Features.Currencies.Commands.Delete
{
    public class DeleteCurrencyCommand : IRequest
    {
        public int CurrencyId { get; set; }
    }
}
