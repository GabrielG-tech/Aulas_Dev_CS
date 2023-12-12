using BancoWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BancoWebApp.Data {
    public class BancoDbContext : DbContext {

        private const string 
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoAT;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Conta> Contas { get; set; }
    }
}
