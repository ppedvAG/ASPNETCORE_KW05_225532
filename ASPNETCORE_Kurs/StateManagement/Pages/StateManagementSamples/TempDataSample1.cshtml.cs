using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StateManagement.Pages.StateManagementSamples
{
    public class TempDataSample1Model : PageModel
    {
        public void OnGet()
        {
            TempData.Add("Film", "Batmann");

        }
    }
}
