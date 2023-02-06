using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RoutingSamples.Pages.Sample.FriendlyRouteSample
{
    public class FriendlyRouteSampleModel : PageModel
    {
        //vorher  -> https://localhost:7227/sample/friendlyRouteSample/friendlyRouteSample?year=2022&day=12&month=5&title=abc
        //Beispiel1-> https://localhost:7227/blog/2022/9/15/abc

        //Beispiel2 -> https://localhost:7227/Blog?year=2021&month=3&day=15&title=abc
        public void OnGet(int year, int month, int day, string title)
        {

        }
    }
}
