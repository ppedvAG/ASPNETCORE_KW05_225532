namespace RazorPages_Samples.Models
{
    public class Movie
    {
        public int Id { get; set; } 
        public string Title { get; set; }   
        public string Description { get; set; }
        public decimal Price { get; set; }


        public GenreType Genre { get; set; }    

    }

    public enum GenreType { Action, Drama, Comedy, Thriller, Crime, Horror, Romance, ScienceFiction, Biography, Docu, Animation}

}
