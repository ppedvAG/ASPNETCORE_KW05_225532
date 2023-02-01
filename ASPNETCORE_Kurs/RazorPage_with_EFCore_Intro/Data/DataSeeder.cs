using RazorPage_with_EFCore_Intro.Models;

namespace RazorPage_with_EFCore_Intro.Data
{
    public static class DataSeeder
    {

        public static void SeedMoviesInDb(MovieDbContext context)
        {
            //Wenn die Tabelle leer ist  
            if (!context.Movies.Any())
            {
                context.Movies.Add(new Movie { Title = "Coda", Description = "Singtalen", Price = 10, Year = 2021, Genre = GenreType.Drama });
                context.Movies.Add(new Movie { Title = "Coda 2", Description = "Singtalen", Price = 10, Year = 2021, Genre = GenreType.Drama });
                context.Movies.Add(new Movie { Title = "Coda 3", Description = "Singtalen", Price = 10, Year = 2021, Genre = GenreType.Drama });


                context.SaveChanges(); //Hier wird das SQL erstellt. = Wenn wir ein "Muss"-Feld nicht ausgefüllt haben, bekommen wir in SaveChange eine Exception 
            }
        }
    }
}
