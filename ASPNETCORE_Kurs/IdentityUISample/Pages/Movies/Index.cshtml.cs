using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityUISample.Data;
using RazorPage_with_EFCore_Intro.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityUISample.Pages.Movies
{

    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IdentityUISample.Data.MovieDbContext _context;

        public IndexModel(IdentityUISample.Data.MovieDbContext context)
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
