using BancoWebApp.Data;
using BancoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BancoWebApp.Pages.Contas
{
    public class DetailsModel : PageModel
    {
        private readonly BancoDbContext _context;

        public DetailsModel(BancoDbContext context) {
            _context = context;
        }
    
        public Conta Conta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id) {

            if (id == null) {
                return NotFound();
            }
            var conta = await _context.Contas.FindAsync(id);
            if (conta == null) {
                return NotFound();
            }
            Conta = conta;
            return Page();
        }
    }
}
