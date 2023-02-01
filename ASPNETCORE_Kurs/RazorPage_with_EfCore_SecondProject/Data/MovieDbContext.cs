using Microsoft.EntityFrameworkCore;
using RazorPage_with_EfCore_SecondProject.Models;

namespace RazorPage_with_EfCore_SecondProject.Data
{
    //DbContext beinhalten den ConnectionString + DbSet<T> sind Tabellen als Objekte 
    public class MovieDbContext : DbContext
    {

        /// <summary>
        /// Konstrutkor
        /// </summary>
        /// <param name="options">Wird in ASP.NET Core in der Program.cs aufgerufen und verwendet</param>
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            :base(options)
        {
        }

        //Wir wollen eine Movie-Tabelle platzieren(im Code First Szenario) 

        //Strg + '.' -> 
        //Name Movies -> repräsentiert in Code Firs den Namen der Tabelle in der zukünftigen DB
        public DbSet<Movie> Movies { get; set; }
    }
}
