using ASPNETCORE_IOCSample.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCORE_IOCSample.Pages.IOCSamples
{
    public class Sample3Model : PageModel
    {
        public ContentResult OnGet()
        {
            //
            ITimeService timeService = HttpContext.RequestServices.GetService<ITimeService>();

            return Content(timeService.GetTime());
        }
    }
}
