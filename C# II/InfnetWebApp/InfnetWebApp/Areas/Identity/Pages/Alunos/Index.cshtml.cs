using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InfnetWebApp.Data;
using InfnetWebApp.Models;

namespace InfnetWebApp.Areas.Identity.Pages.Alunos
{
    public class IndexModel : PageModel
    {
        private readonly InfnetWebApp.Data.InfnetDbContext _context;

        public IndexModel(InfnetWebApp.Data.InfnetDbContext context)
        {
            _context = context;
        }

        public IList<Aluno> Aluno { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Aluno != null)
            {
                Aluno = await _context.Aluno.ToListAsync();
            }
        }
    }
}
