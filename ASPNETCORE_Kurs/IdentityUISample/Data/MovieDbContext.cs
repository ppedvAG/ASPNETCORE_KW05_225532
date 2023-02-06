using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPage_with_EFCore_Intro.Models;

namespace IdentityUISample.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPage_with_EFCore_Intro.Models.Movie> Movie { get; set; } = default!;
    }
}
