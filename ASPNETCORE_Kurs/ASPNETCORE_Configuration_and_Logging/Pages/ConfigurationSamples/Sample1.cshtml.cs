using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_Configuration_and_Logging.Pages.ConfigurationSamples
{
    public class Sample1Model : PageModel
    {

        //IConfiguration repräsentiert alle geladenen Konfigurationen
        private readonly IConfiguration _configuration;

        public Sample1Model(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ContentResult OnGet()
        {
            string myKeyValue = _configuration["MyKey"];

            string title = _configuration["Position:Title"];

            string name = _configuration["Position:Name"];

            string defaultLogging = _configuration["Logging:LogLevel:Default"];


            return Content($"MyKey value: {myKeyValue} \n" +
                $"Title: {title} \n" +
                $"Name: {name} \n" +
                $"Log-Level: {defaultLogging}");
        }
    }
}
