using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StateManagement.Models;
using System.Text.Json;

namespace StateManagement.Pages.StateManagementSamples
{
    public class SessionEndeModel : PageModel
    {
        public void OnGet()
        {
            string email = HttpContext.Session.GetString("email");

            int? lottozahlen = HttpContext.Session.GetInt32("lottozahlen");
            string json = HttpContext.Session.GetString("OscarFilm");
            Movie movie = JsonSerializer.Deserialize<Movie>(json);  
        }


        //public void SampleMethode (int? param1, int? param2)
        //{
        //    int? meineZahl = null;
        //    int ohneFragezeichen = null;
        //    string str = null;
        //    if (string.IsNullOrEmpty(str))
        //    {
        //    }
        //    if (string.IsNullOrWhiteSpace(str))
        //    {
        //    }
        //}
    }
}
