using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesApp.Persistence.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        private readonly ExpensesAppDbContext _dbContext;

        public ClientRepository(ExpensesAppDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> ClientExists(string code)
        {
            var clientExists = _dbContext.Clients.Any(x => x.Code == code);

            return Task.FromResult(clientExists);
        }
    }
}
