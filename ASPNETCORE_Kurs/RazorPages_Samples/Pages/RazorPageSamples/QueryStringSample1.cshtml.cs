using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_Samples.Pages.RazorPageSamples
{
    public class QueryStringSample1Model : PageModel
    {
        //Ein Querystring https://localhost:12345/Webseite?id=123&secondParam=HalloWelt
        //Query-Parameter sind:
        //id = 123
        //secondParam = Hallo Welt 

        public string Name { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }


        //https://localhost:7164/RazorPageSamples/QueryStringSample1?name=Otto&year=2022&month=8
        public void OnGet(string name, int year, int month)
        {
            Name = name;
            Year = year;    
            Month = month;
        }
    }
}
