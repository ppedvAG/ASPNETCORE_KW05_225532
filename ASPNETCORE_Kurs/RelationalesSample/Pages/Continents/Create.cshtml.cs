using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelationalesSample.Data;
using RelationalesSample.Models;

namespace RelationalesSample.Pages.Continents
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
            return Page();
        }

        [BindProperty]
        public Continent Continent { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            ModelState.Remove("Continent.Countries");
            if (!ModelState.IsValid || _context.Continents == null || Continent == null)
            {
                return Page();
            }

            _context.Continents.Add(Continent);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
