using BancoWebApp.Data;
using BancoWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BancoWebApp.Pages.Contas
{
    public class CreateModel : PageModel
    {
        private readonly BancoDbContext _context;

        public CreateModel(BancoDbContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            return Page();
        }

        [BindProperty]
        public Conta Conta { get; set; }

        public async Task<IActionResult> OnPostAsync() {

            if (!ModelState.IsValid) {
                return Page();
            }
            _context.Contas.Add(Conta);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
