using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesApp.Persistence.Repositories
{
    public class ClientRoleRepository : BaseRepository<ClientRole>, IClientRolesRepository
    {

        public ClientRoleRepository(ExpensesAppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<bool> ClientRoleWithCodeExists(string clientRoleCode)
        {
            var clientRoleExist = _dbContext.ClientRoles.Any(x => x.Code == clientRoleCode);
            return Task.FromResult(clientRoleExist);
        }

        public Task<bool> ClientRoleWithIdExists(int clientRoleId)
        {
            var clientRoleExist = _dbContext.ClientRoles.Any(x => x.ClientRoleId == clientRoleId);
            return Task.FromResult(clientRoleExist);
        }
    }
}
