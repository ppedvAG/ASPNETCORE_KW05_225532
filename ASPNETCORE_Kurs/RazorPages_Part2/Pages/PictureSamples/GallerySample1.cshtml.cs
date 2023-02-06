using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Packaging;

namespace RazorPages_Part2.Pages.PictureSamples
{
    public class GallerySample1Model : PageModel
    {


        public IList<string> Bilder { get; set; } 

        public GallerySample1Model()
        {
            Bilder = new List<string>();
        }

        public void OnGet()
        {
            string pfad  = AppDomain.CurrentDomain.GetData("Bildverzeichnis") + @"\uploaded_pictures\";

            string[] allFiles = Directory.GetFiles(pfad);

            Bilder.AddRange(allFiles);
        }
    }
}
