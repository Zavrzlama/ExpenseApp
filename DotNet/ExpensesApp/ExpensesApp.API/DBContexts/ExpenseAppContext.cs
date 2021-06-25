using ExpensesApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesApp.API.DBContexts
{
    public class ExpenseAppContext : DbContext
    {
        public DbSet<ClientRole> ClientRoles { get; set; }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }

        public DbSet<Client> Clients { get; set; }

        public ExpenseAppContext(DbContextOptions<ExpenseAppContext> options) : base(options)
        {
        }

    }
}
