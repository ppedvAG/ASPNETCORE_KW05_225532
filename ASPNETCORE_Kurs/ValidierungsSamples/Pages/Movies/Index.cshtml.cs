using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ValidierungsSamples.Data;
using ValidierungsSamples.Models;

namespace ValidierungsSamples.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ValidierungsSamples.Data.MovieDbContext _context;

        public IndexModel(ValidierungsSamples.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
