using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StateManagement.Pages.StateManagementSamples
{
    public class ViewBagSampleModel : PageModel
    {
        public void OnGet()
        {
            ViewData["lottozahlen"] = "12-21-23-32-54-11"; 

            
        }
    }
}
