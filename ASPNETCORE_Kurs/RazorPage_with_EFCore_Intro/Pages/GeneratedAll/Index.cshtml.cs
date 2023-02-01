using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_with_EFCore_Intro.Data;
using RazorPage_with_EFCore_Intro.Models;

namespace RazorPage_with_EFCore_Intro.Pages.GeneratedAll
{
    public class IndexModel : PageModel
    {
        private readonly RazorPage_with_EFCore_Intro.Data.MovieDbContext _context;

        public IndexModel(RazorPage_with_EFCore_Intro.Data.MovieDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movies != null)
            {
                Movie = await _context.Movies.ToListAsync();
            }
        }
    }
}
