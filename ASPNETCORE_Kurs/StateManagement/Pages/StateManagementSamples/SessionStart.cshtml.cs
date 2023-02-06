using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StateManagement.Models;
using System.Text.Json;

namespace StateManagement.Pages.StateManagementSamples
{
    public class SessionStartModel : PageModel
    {
        public IActionResult OnGet()
        {
            this.HttpContext.Session.SetInt32("lottozahlen", 1234567);
            this.HttpContext.Session.SetString("email", "kevinw@ppedv.de");


            Movie movie = new()
            {
                Id = 123,
                Title = "Triangle of Sadness",
                Description = "Lustiger Satire"
            };

            string json = JsonSerializer.Serialize(movie);

            this.HttpContext.Session.SetString("OscarFilm", json);


            return RedirectToPage("./SessionEnde");
        }
    }
}
