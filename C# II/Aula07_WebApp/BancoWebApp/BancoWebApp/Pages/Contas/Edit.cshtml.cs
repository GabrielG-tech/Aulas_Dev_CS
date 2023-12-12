using BancoWebApp.Data;
using BancoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BancoWebApp.Pages.Contas
{
    public class EditModel : PageModel
    {
        private readonly BancoDbContext _context;

        public EditModel(BancoDbContext context) {
            _context = context;
        }

        [BindProperty] // Decorator
        public Conta Conta { get; set; }

        public IActionResult OnGet(int id) {

            if (id == null) {
                return NotFound();
            }
            var conta = _context.Contas.Find(id);
            if (conta == null) {
                return NotFound();
            }
            Conta = conta;
            return Page();
        }

        public IActionResult OnPost() {

            if (!ModelState.IsValid) {
                return Page();
            }
            _context.Contas.Update(Conta);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
