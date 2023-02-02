using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RelationalesSample.Data;
using RelationalesSample.Models;

namespace RelationalesSample.Pages.Continents
{
    public class IndexModel : PageModel
    {
        private readonly RelationalesSample.Data.GeoDbContext _context;

        public IndexModel(RelationalesSample.Data.GeoDbContext context)
        {
            _context = context;
        }

        public IList<Continent> Continent { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Continents != null)
            {
                Continent = await _context.Continents.ToListAsync();
            }
        }
    }
}
