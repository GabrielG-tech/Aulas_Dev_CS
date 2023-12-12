using BancoWebApp.Data;
using BancoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BancoWebApp.Pages.Contas
{
    public class DeleteModel : PageModel
    {
        private readonly BancoDbContext _context;

        public DeleteModel(BancoDbContext context) {
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

        public async Task<IActionResult> OnPostAsync(int? id) {

            if (id == null) {
                return NotFound();
            }
            var conta = await _context.Contas.FindAsync(id);
            if (conta != null) {
                _context.Contas.Remove(conta);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("Index");
        }
    }
}
