using System.Collections.Generic;
using ExpensesApp.API.Entities;

namespace ExpensesApp.API.Services
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetClinets();

        Client GetClient(int id);

        bool ClientExists(int id);

        void AddClient(Client client);

        void DeleteClient(Client client);

        bool Save();
    }
}
