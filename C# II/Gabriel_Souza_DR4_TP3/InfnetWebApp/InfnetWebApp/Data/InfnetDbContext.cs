using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InfnetWebApp.Models;

namespace InfnetWebApp.Data {
    public class InfnetDbContext: IdentityDbContext {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options)
            : base(options) {
        }
        public DbSet<InfnetWebApp.Models.Aluno>? Aluno { get; set; }
    }
}
