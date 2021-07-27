using ExpensesAppDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesAppDAL.DbContexts
{
    public class ExpenseAppContext : DbContext
    {
        public DbSet<ClientRole> ClientRoles { get; set; }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }

        public DbSet<Client> Clients { get; set; }

        public ExpenseAppContext(DbContextOptions<ExpenseAppContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TO-DO
            //optionsBuilder.UseNpgsql()
        }
    }
}
