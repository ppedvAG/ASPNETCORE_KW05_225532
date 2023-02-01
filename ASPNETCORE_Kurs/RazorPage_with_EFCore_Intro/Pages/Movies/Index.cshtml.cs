using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_with_EFCore_Intro.Data;
using RazorPage_with_EFCore_Intro.Models;

namespace RazorPage_with_EFCore_Intro.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private MovieDbContext _context;


        public IList<Movie> Movies { get; set; }

        //Wir benötigen den MovieDbContext für den DB Zugriff (wird aus IOC Container gelesen)
        public IndexModel(MovieDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGet()
        {
            //Initialisieren das VM 
            Movies = await _context.Movies.ToListAsync();

            return Page(); 
        }
    }
}
