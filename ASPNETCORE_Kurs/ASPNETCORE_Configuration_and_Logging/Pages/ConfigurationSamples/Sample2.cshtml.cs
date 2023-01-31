using ASPNETCORE_Configuration_and_Logging.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace ASPNETCORE_Configuration_and_Logging.Pages.ConfigurationSamples
{
    public class Sample2Model : PageModel
    {

        private GameSettings GameConfigSettings { get; set; }


        //https://learn.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-7.0
        public Sample2Model(IOptionsSnapshot<GameSettings> gameSettings)
        {
            GameConfigSettings = gameSettings.Value;
        }
        public ContentResult OnGet()
        {
            return Content(GameConfigSettings.Title);
        }
    }
}
