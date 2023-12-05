using Microsoft.EntityFrameworkCore;

namespace Banco {
    public class BancoDbContext : DbContext {

        const string connectionString = 
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoAT;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Conta> Contas { get; set; }
    }
}
