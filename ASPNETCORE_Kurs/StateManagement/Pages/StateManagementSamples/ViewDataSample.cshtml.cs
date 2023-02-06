using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StateManagement.Pages.StateManagementSamples
{
    public class ViewDataSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData.Add("Lottozahlen", "12-34-54-23-54-3");
            ViewData["EmailAdresse"] = "kevinw@ppedv.de";
        }
    }
}
