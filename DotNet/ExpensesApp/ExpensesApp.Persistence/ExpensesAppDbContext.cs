using ExpensesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesApp.Persistence
{
    public class ExpensesAppDbContext :DbContext
    {
        public DbSet<ClientRole> ClientRoles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ExpenseImport> ExpenseImport { get; set; }

        public ExpensesAppDbContext(DbContextOptions<ExpensesAppDbContext> options) : base(options)
        {

        }

    }
}
