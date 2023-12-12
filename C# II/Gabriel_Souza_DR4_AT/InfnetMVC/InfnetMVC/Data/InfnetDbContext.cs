using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InfnetMVC.Models;

namespace InfnetMVC.Data {
    public class InfnetDbContext: IdentityDbContext {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options)
            : base(options) {
        }
        public DbSet<InfnetMVC.Models.Aluno>? Aluno { get; set; }
    }
}
