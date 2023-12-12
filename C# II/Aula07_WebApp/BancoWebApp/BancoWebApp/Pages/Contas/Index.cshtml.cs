using BancoWebApp.Data;
using BancoWebApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

namespace BancoWebApp.Pages.Contas
{
    public class IndexModel : PageModel
    {
        private readonly BancoDbContext _context;

        public IndexModel(BancoDbContext context) {
            _context = context;
        }

        public IList<Conta> Contas { get; set; }

        public async Task OnGetAsync() {

            if (_context.Contas != null) {
                Contas = await _context.Contas.ToListAsync(); 
            }
        }
    }
}
