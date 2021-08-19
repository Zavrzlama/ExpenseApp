using ExpensesApp.Domain.Entities;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Contracts.Persistence
{
    public interface IClientRolesRepository : IAsyncRepository<ClientRole>
    {
        Task<bool> ClientRoleNameExists(string ClientRoleName);
    }
}