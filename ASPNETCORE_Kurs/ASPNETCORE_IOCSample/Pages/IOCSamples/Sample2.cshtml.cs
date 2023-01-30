using ASPNETCORE_IOCSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_IOCSample.Pages.IOCSamples
{
    public class Sample2Model : PageModel
    {
        public ContentResult OnGet([FromServices] ITimeService timeService)
        {
             return Content(timeService.GetTime());
        }
    }
}
