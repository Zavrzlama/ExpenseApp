using System.Threading.Tasks;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Contracts.Persistence
{
    public interface IStoreRepository : IAsyncRepository<Store>
    {
        Task<bool> StoreWithCodeExists(string code);
    }
}