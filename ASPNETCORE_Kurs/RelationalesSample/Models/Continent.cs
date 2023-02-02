using System.ComponentModel.DataAnnotations.Schema;

namespace RelationalesSample.Models
{
    public class Continent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //[NotMapped]
        //public string CombineField { get; }

        //Navigation
        public ICollection<Country> Countries { get; set; }

    }
}
