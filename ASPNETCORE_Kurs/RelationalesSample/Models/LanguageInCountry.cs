using System.ComponentModel;

namespace RelationalesSample.Models
{
    public class LanguageInCountry
    {
        public int Id { get; set; } 

        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public int Percent { get; set; }


        //Navigation
        [DisplayName("Sprache")]
        public Language LanguageRef { get; set; }


        [DisplayName("Land")]
        public Country CountryRef { get; set; } 
    }
}
