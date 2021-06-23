using System.Collections.Generic;
using System.Linq;
using ExpensesApp.API.Entities;

namespace ExpensesApp.API.Services
{
    public interface IClientRolesRepository
    {
        IEnumerable<ClientRole> GetRoles();

        ClientRole GetClientRole(int id);

        bool ClientRoleExists(int id);

        void AddClientRole(ClientRole clientRole);

        void DeleteClientRole(ClientRole clientRole);

        bool Save();
    }
}
