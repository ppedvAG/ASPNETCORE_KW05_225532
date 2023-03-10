using System.ComponentModel.DataAnnotations;
using ValidierungsSamples.Data;
using ValidierungsSamples.Models;

namespace ValidierungsSamples.Attributes
{
    public class ClassicMovieAttribute : ValidationAttribute
    {
        public int Year { get; set; }

        public ClassicMovieAttribute(int year)
        {
            Year = year;
        }

        public string GetErrorMessage() =>
            $"Filmklassiker sind alle vor {Year} erschienen";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            using (IServiceScope scope = validationContext.CreateScope())
            {
                MovieDbContext ctx = scope.ServiceProvider.GetRequiredService<MovieDbContext>();
                //....
            }

            Movie movie = (Movie)validationContext.ObjectInstance;

            int releaseYear = (int)value;

            if (movie.Genre == GenreType.Classics && releaseYear > Year)
            {
                return new ValidationResult(GetErrorMessage());
            }


            return ValidationResult.Success;

        }



    }
}
