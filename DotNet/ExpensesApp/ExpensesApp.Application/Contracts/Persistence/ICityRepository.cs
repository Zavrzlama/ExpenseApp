using System.Threading.Tasks;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Contracts.Persistence
{
    public interface ICityRepository : IAsyncRepository<City>
    {
        Task<bool> CityWithZipCOdeExists(string zipcode);
    }
}