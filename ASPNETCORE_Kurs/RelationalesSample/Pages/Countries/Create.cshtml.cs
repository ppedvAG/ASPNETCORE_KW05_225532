using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelationalesSample.Data;
using RelationalesSample.Models;

namespace RelationalesSample.Pages.Countries
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
            ViewData["ContinentId"] = new SelectList(_context.Continents, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Country Country { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            ModelState.Remove("Country.ContinentRef");
            ModelState.Remove("Country.LanguagesInCountries");
            if (!ModelState.IsValid || _context.Countries == null || Country == null)
            {
                return Page();
            }

            _context.Countries.Add(Country);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
