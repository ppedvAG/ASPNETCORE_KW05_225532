using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Samples.Models;

namespace RazorPages_Samples.Pages.IntroSamples
{
    public class SecondSample_ShowMovieTableModel : PageModel
    {
        public IList<Movie> Movies { get; set; } = new List<Movie>();

        //... weitere Public-Member und das VM erweitern +


        public void OnGet()
        {
            Movies.Add(new Movie() { Id = 1, Title = "Jurassic Park", Description = "Dinos z?chten Menschen", Genre = GenreType.Horror, Price= 10 });
            Movies.Add(new Movie() { Id = 2, Title = "Jurassic Park 2", Description = "T-Rex wird Veganer", Genre = GenreType.Horror, Price = 120 });
            Movies.Add(new Movie() { Id = 3, Title = "Batman", Description = "Batman und Harley Quinn heiraten", Genre = GenreType.Horror, Price = 130 });
            Movies.Add(new Movie() { Id = 4, Title = "Fast & Furios 123", Description = "Never Ending Story", Genre = GenreType.Horror, Price = 11 });

        }
    }
}
