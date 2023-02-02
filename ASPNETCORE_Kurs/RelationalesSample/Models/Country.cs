using System.ComponentModel;

namespace RelationalesSample.Models
{
    public class Country
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public int ContinentId { get; set; }


        //Navigation
        public ICollection<LanguageInCountry> LanguagesInCountries { get; set; }


        [DisplayName("Kontinent")]
        public Continent ContinentRef { get; set; }
    }
}
