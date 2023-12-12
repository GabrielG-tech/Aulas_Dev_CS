﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using InfnetWebApp.Data;
using InfnetWebApp.Models;

namespace InfnetWebApp.Areas.Identity.Pages.Alunos
{
    public class CreateModel : PageModel
    {
        private readonly InfnetWebApp.Data.InfnetDbContext _context;

        public CreateModel(InfnetWebApp.Data.InfnetDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Aluno Aluno { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Aluno == null || Aluno == null)
            {
                return Page();
            }

            _context.Aluno.Add(Aluno);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
