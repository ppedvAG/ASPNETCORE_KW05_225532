using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_Samples.Pages.RazorPageSamples
{
    public class PageHandlerModel : PageModel
    {
        //Wert in dieser Variable repräsentiert den Methoden-Namen der verwendeten Get-Methode 
        public string MethodenEinstieg { get; set; }

        //https://localhost:7164/RazorPageSamples/PageHandler
        public void OnGet()
        {
            MethodenEinstieg = "OnGet wird aufgerufen";
        }

        //https://localhost:7164/RazorPageSamples/PageHandler?test=hallo -> Multiple handlers matched. The following handlers matched route data and had all constraints satisfied:
        public void OnGet(string test)
        {
            MethodenEinstieg = "OnGet wird aufgerufen";
        }

        //Deswegen verwenden wir Handler 

        //Zweite Get-Methode: https://localhost:7164/RazorPageSamples/PageHandler?handler=demo
        public void OnGetDemo()
        {
            MethodenEinstieg = "OnGetDemo wird aufgerufen";
        }

        public void OnGetDemoWithParam(string param)
        {
            MethodenEinstieg = "OnGetDemoWithParam";
        }

    }
}
