//#nullable disable

namespace ASPNETCORE_Configuration_and_Logging.Configurations
{

    //Klassen- und Property-Name müssen mit der Settings übereinstimmen
    public class GameSettings
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public string[] Updates { get; set; } = default!;

        public Publisher Publisher { get; set; } = default!;

    }

    public class Publisher
    {
        public string Name { get; set; }
    }
   

   

}
