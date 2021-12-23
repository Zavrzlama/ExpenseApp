using ExpensesApp.Domain.Entities;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Contracts.Persistence
{
    public interface IClientRolesRepository : IAsyncRepository<ClientRole>
    {
        Task<bool> ClientRoleWithCodeExists(string clientRoleCode);

        Task<bool> ClientRoleWithIdExists(int clientRoleId);
    }
}