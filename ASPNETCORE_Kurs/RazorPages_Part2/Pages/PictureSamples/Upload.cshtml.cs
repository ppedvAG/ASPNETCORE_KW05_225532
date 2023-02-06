using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_Part2.Pages.PictureSamples
{
    public class UploadModel : PageModel
    {
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);

            string absoluteSavePath = AppDomain.CurrentDomain.GetData("Bildverzeichnis") + @"\uploaded_pictures\" + fileInfo.Name;

            using (FileStream fs = new FileStream(absoluteSavePath, FileMode.Create))
            {
                await datei.CopyToAsync(fs);
            }

            return RedirectToPage("Upload");
        }



    }
}
