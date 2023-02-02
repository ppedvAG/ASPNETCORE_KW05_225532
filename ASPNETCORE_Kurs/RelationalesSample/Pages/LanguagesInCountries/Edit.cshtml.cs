using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RelationalesSample.Data;
using RelationalesSample.Models;

namespace RelationalesSample.Pages.LanguagesInCountries
{
    public class EditModel : PageModel
    {
        private readonly RelationalesSample.Data.GeoDbContext _context;

        public EditModel(RelationalesSample.Data.GeoDbContext context)
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

            var languageincountry =  await _context.LagnaugesInCountries.FirstOrDefaultAsync(m => m.Id == id);
            if (languageincountry == null)
            {
                return NotFound();
            }
            LanguageInCountry = languageincountry;
           ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
           ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("LanguageInCountry.LanguageRef");
            ModelState.Remove("LanguageInCountry.CountryRef");


            int languagePercentSum = _context.LagnaugesInCountries.Where(c => c.CountryId == LanguageInCountry.CountryId).Sum(c => c.Percent);

            if (languagePercentSum + LanguageInCountry.Percent > 100)
            {
                ModelState.AddModelError("LanguageInCountry.Percent", $"Es kann höchsten noch {100 - languagePercentSum} % vergeben werden");
            }


            if (!ModelState.IsValid)
            {
                ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "Name");
                ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Name");
                return Page();
            }

            _context.Attach(LanguageInCountry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanguageInCountryExists(LanguageInCountry.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LanguageInCountryExists(int id)
        {
          return (_context.LagnaugesInCountries?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
