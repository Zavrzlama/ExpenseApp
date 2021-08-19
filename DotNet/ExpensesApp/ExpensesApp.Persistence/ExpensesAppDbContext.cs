using ExpensesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesApp.Persistence
{
    public class ExpensesAppDbContext :DbContext
    {
        public DbSet<ClientRole> ClientRoles { get; set; }

        public ExpensesAppDbContext(DbContextOptions<ExpensesAppDbContext> options) : base(options)
        {

        }

    }
}
