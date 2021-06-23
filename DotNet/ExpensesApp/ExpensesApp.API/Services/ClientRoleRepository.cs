using System;
using System.Collections.Generic;
using System.Linq;
using ExpensesApp.API.DBContexts;
using ExpensesApp.API.Entities;

namespace ExpensesApp.API.Services
{
    public class ClientRoleRepository : IClientRolesRepository
    {
        private readonly ExpenseAppContext _dbContext;

        //private readonly ExpenseAppContext _dbContext;

        public ClientRoleRepository(ExpenseAppContext dbContext)
        {
            _dbContext = dbContext ??  throw new ArgumentNullException();
        }

        public IEnumerable<ClientRole> GetRoles()
        {
            return _dbContext.ClientRoles.ToList();
        }

        public ClientRole GetClientRole(int id)
        {
            return _dbContext.ClientRoles.FirstOrDefault(x => x.ID == id);
        }

        public bool ClientRoleExists(int id)
        {
            return _dbContext.ClientRoles.Any(x=> x.ID == id);
        }

        public void AddClientRole(ClientRole clientRole)
        {
            _dbContext.ClientRoles.Add(clientRole);
        }

        public void DeleteClientRole(ClientRole clientRole)
        {
            _dbContext.Remove(clientRole);
        }

        public bool Save()
        {
            return (_dbContext.SaveChanges() >= 0);
        }

      
    }
}