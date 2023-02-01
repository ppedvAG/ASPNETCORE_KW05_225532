using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_with_EFCore_Intro.Data;
using RazorPage_with_EFCore_Intro.Models;

namespace RazorPage_with_EFCore_Intro.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPage_with_EFCore_Intro.Data.MovieDbContext _context;

        public DetailsModel(RazorPage_with_EFCore_Intro.Data.MovieDbContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            //Ist überhaupt eine ID angekommen 
            if (id == null || _context.Movies == null)
            {
                return NotFound(); //Gebe 404 zurück
            }

            Movie movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound(); //404
            }
            else 
            {
                //alles andere initialisierung von Movie
                Movie = movie;
            }
            return Page();
        }
    }
}
