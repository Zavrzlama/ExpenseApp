using System.Threading.Tasks;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Contracts.Persistence
{
    public interface ICurrencyRepository : IAsyncRepository<Currency>
    {
        Task<bool> CurrencyWithCodeExists(string code);
    }
}
