using System.ComponentModel.DataAnnotations;

namespace RazorPages_Part2.Models
{
    public class Movie
    {
        public int Id { get; set; } //EfCore versteht, per Default, dass hier ist ein Primary-Key

        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public int Year { get; set; }
        public GenreType Genre { get; set; }

    }

    public enum GenreType { Action, Drama, Comedy, Thriller, Crime, Horror, Romance, ScienceFiction, Biography, Docu, Animation, Classics }
}
