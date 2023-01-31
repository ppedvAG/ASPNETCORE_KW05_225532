using ASPNETCORE_IOCSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_IOCSample.Pages.IOCSamples
{
    
    //Controller Klassen (MVC) oder PageModel-Klassen werden via einer Factory erstellt 
    public class Sample1Model : PageModel
    {
        private ITimeService _timeService;


        //Konstructor Injection, greift auf IOC Container zu 
        public Sample1Model(ITimeService timeService)
        {
            _timeService = timeService;
        }


        //Es wird ein einfacher String ausgegeben 
        public ContentResult OnGet()
        {
            return Content(_timeService.GetTime());
        }
    }
}
