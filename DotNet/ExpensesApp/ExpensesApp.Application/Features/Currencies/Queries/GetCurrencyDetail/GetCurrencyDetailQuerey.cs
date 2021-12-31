using MediatR;

namespace ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyDetail
{
    public class GetCurrencyDetailQuerey : IRequest<CurrencyDetailDTO>
    {
        public int CurrencyId { get; set; }
    }
}
