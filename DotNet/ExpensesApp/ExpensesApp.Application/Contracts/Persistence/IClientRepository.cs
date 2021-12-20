using ExpensesApp.Domain.Entities;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Contracts.Persistence
{
    public interface IClientRepository : IAsyncRepository<Client>
    {
        Task<bool> ClientExists(string code);
    }
}