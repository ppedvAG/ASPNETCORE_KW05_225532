using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_Samples.Models;

namespace RazorPages_Samples.Pages.IntroSamples
{
    public class FirstSample_ShowMovieModel : PageModel
    {
        public Movie MovieObj { get; set; }

        private ILogger<FirstSample_ShowMovieModel> _logger;


        public FirstSample_ShowMovieModel(ILogger<FirstSample_ShowMovieModel> logger)
        {
            //Zuweisung von Services aus IOC 

            _logger = logger;
        }

        //Wir bei jedem Request aufgerufen 
        public void OnGet()
        {
            
            //Datenbankzugriffe -> bereitstellen eines Movie-Objektes
            //Movie Objekt via RestFul Service auslesen 
            //...Oder einfach ein Movie-Objekt instanziieren


            MovieObj = new Movie() { Title = "Coda", Description = "Talentierte Sängerin", Price = 11m, Genre = GenreType.Drama, Id = 1 };
        }
    }
}
