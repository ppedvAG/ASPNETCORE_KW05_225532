using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DataAnnotationsLocalisation.Pages
{
    public class ContactModel : PageModel
    {

        [Display(Name = "Message"), Required(ErrorMessage = "Message Required")]
        public string Message { get; set; }
        [Display(Name = "First Name"), Required(ErrorMessage = "First Name Required")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name"), Required(ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }
        [Display(Name = "Email"), Required(ErrorMessage = "Email Required"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public void OnGet()
        {
        }
    }
}
