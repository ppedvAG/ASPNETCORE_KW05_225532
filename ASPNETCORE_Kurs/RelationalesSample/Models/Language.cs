namespace RelationalesSample.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Navigation
        public ICollection<LanguageInCountry> LanguagesInCountries { get; set; } 
    }
}
