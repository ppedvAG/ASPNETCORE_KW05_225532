
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CheckboxListSample.Models;
using CheckboxListSample.Data;
using System.Diagnostics;

namespace CheckboxListSample.Pages
{
    public class CourseSelectionModel : PageModel
    {
        [BindProperty]
        public IList<CheckboxViewModel> SampleModel { get; set; }
        
        public void OnGet()
        {
            SampleModel = Repository.GetCourses();
        }

        public void OnPost()
        {
            foreach (CheckboxViewModel item in SampleModel)
            {
                Debug.WriteLine($"{item.Id} |{item.LabelName} | {item.IsChecked} ");
            }
        }
    }
}
