using System;
using System.Collections.Generic;
using System.Linq;
using ExpensesApp.API.DBContexts;
using ExpensesApp.API.Entities;

namespace ExpensesApp.API.Services
{
    public class ClientRepository : IClientRepository
    {
        private readonly ExpenseAppContext _dbContext;

        public ClientRepository(ExpenseAppContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IEnumerable<Client> GetClinets()
        {
            return _dbContext.Clients.ToList();
        }

        public Client GetClient(int id)
        {
            return _dbContext.Clients.FirstOrDefault(x => x.ClientId == id);
        }

        public bool ClientExists(int id)
        {
            return _dbContext.Clients.Any(x => x.ClientId == id);
        }

        public void AddClient(Client client)
        {
            _dbContext.Clients.Add(client);
        }

        public void DeleteClient(Client client)
        {
            _dbContext.Remove(client);
        }

        public bool Save()
        {
            return (_dbContext.SaveChanges() >= 0);
        }
    }
}