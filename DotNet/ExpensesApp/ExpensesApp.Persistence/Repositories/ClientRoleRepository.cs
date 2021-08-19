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

        public Task<bool> ClientRoleNameExists(string ClientRoleName)
        {
            var clientRoleExist = _dbContext.ClientRoles.Any(x => x.RoleName == ClientRoleName);
            return Task.FromResult(clientRoleExist);
        }
    }
}
