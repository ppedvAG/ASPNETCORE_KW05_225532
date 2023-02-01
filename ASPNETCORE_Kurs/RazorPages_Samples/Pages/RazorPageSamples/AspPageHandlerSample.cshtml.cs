using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_Samples.Pages.RazorPageSamples
{
    public class AspPageHandlerSampleModel : PageModel
    {
        public int Ergebnis { get; set; }


        public void OnGet()
        {
            Ergebnis = 0;
        }


        //Formular wird an die Post-Methode �bermittelt 
        public void OnPost() //OnPost ist eine Konvention genauso wie OnGet
        {
            //Wir lesen die Werte mit der �lteste aus 
            int a, b = 0;

            //Request.Form -> Formular das wir in der UI ausgef�llt haben
            int.TryParse(Request.Form["eins"], out a); //Der Inhalt von TextBox("eins") wird in Integer 'a' gespeichert
            int.TryParse(Request.Form["zwei"], out b);

            Ergebnis = a + b;
        }
    }
}
