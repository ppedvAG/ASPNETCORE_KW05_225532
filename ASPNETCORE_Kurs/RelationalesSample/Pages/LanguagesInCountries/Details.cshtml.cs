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
    public class DetailsModel : PageModel
    {
        private readonly RelationalesSample.Data.GeoDbContext _context;

        public DetailsModel(RelationalesSample.Data.GeoDbContext context)
        {
            _context = context;
        }

      public LanguageInCountry LanguageInCountry { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.LagnaugesInCountries == null)
            {
                return NotFound();
            }

            var languageincountry = await _context.LagnaugesInCountries.Include("LanguageRef")
                                                                       .Include("CountryRef")
                                                                       .FirstOrDefaultAsync(m => m.Id == id);
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
    }
}
