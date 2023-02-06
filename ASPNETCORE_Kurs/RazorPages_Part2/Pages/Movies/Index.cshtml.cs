using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_Part2.Data;
using RazorPages_Part2.Models;

namespace RazorPages_Part2.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages_Part2.Data.MovieDbContext _context;

        public IndexModel(RazorPages_Part2.Data.MovieDbContext context)
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
