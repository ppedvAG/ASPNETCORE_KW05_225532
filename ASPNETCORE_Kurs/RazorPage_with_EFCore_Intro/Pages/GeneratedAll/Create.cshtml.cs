using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPage_with_EFCore_Intro.Data;
using RazorPage_with_EFCore_Intro.Models;

namespace RazorPage_with_EFCore_Intro.Pages.GeneratedAll
{
    public class CreateModel : PageModel
    {
        private readonly RazorPage_with_EFCore_Intro.Data.MovieDbContext _context;

        public CreateModel(RazorPage_with_EFCore_Intro.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Movies == null || Movie == null)
            {
                return Page();
            }

            _context.Movies.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
