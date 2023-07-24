using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Pet Pet { get; set; }       

        public void OnPost()
        {
            //save it to our pet list later
            Debug.WriteLine(Pet.Name);
            Debug.WriteLine(Pet.City);
            Debug.WriteLine(Pet.AgeInMonths);
        }
    }
}
