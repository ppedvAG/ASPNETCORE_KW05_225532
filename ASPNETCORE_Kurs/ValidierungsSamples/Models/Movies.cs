using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ValidierungsSamples.Attributes;

namespace ValidierungsSamples.Models
{
    //Was ist eine Poco-Klasse?

    //Repräsentiert ein Datensatz in einer Tabelle (oder auch auch das Schema steht hier drin -> Relationen) 


    //DataAnnotations -> https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.dataannotations?view=net-7.0

    public class Movie
    {
        public int Id { get; set; } //EfCore versteht, per Default, dass hier ist ein Primary-Key

        [MaxLength(100)]    
        public string Title { get; set; }


        [Required]
        [DisplayName("Beschreibung")]
        public string Description { get; set; }


        [DisplayName("Preis")]
        public decimal Price { get; set; }

        [ClassicMovie(1960)]
        public int Year { get; set; }
        public GenreType Genre { get; set; }

        //Navigation 

    }

    public enum GenreType { Action, Drama, Comedy, Thriller, Crime, Horror, Romance, ScienceFiction, Biography, Docu, Animation, Classics }
}
