using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelationalesSample.Data;
using RelationalesSample.Models;

namespace RelationalesSample.Pages.LanguagesInCountries
{
    public class CreateModel : PageModel
    {
        private readonly RelationalesSample.Data.GeoDbContext _context;

        public CreateModel(RelationalesSample.Data.GeoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public LanguageInCountry LanguageInCountry { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("LanguageInCountry.LanguageRef");
            ModelState.Remove("LanguageInCountry.CountryRef");

            //languagePercentSum der bisher vergebene Sprachen in einem Land
            int languagePercentSum = _context.LagnaugesInCountries.Where(c => c.CountryId == LanguageInCountry.CountryId).Sum(c => c.Percent);

            if (languagePercentSum + LanguageInCountry.Percent > 100) 
            {
                ModelState.AddModelError("LanguageInCountry.Percent", $"Es kann höchsten noch {100 - languagePercentSum} % vergeben werden");
            }

            if (!ModelState.IsValid || _context.LagnaugesInCountries == null || LanguageInCountry == null)
            {
                ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
                ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Name");
                return Page();
            }

            _context.LagnaugesInCountries.Add(LanguageInCountry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
