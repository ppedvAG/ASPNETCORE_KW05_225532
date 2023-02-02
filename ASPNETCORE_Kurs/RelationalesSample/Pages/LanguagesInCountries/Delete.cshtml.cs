using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RelationalesSample.Data;
using RelationalesSample.Models;

namespace RelationalesSample.Pages.LanguagesInCountries
{
    public class DeleteModel : PageModel
    {
        private readonly RelationalesSample.Data.GeoDbContext _context;

        public DeleteModel(RelationalesSample.Data.GeoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public LanguageInCountry LanguageInCountry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LagnaugesInCountries == null)
            {
                return NotFound();
            }

            var languageincountry = await _context.LagnaugesInCountries.FirstOrDefaultAsync(m => m.Id == id);

            if (languageincountry == null)
            {
                return NotFound();
            }
            else 
            {
                LanguageInCountry = languageincountry;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.LagnaugesInCountries == null)
            {
                return NotFound();
            }
            var languageincountry = await _context.LagnaugesInCountries.FindAsync(id);

            if (languageincountry != null)
            {
                LanguageInCountry = languageincountry;
                _context.LagnaugesInCountries.Remove(LanguageInCountry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
