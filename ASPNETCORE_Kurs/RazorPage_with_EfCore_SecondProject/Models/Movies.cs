using System.ComponentModel.DataAnnotations;

namespace RazorPage_with_EfCore_SecondProject.Models
{
    //Was ist eine Poco-Klasse?

    //Repräsentiert ein Datensatz in einer Tabelle (oder auch auch das Schema steht hier drin -> Relationen) 

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
