using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Pet Pet { get; set; }

        public List<SelectListItem> DropDownItems { get; set; }

        public IActionResult OnGet()
        {
            // Create a new list with hardcoded SelectListItem objects
            DropDownItems = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "Dog" },
                new SelectListItem { Value = "1", Text = "Cat" }
            };

            return Page();
        }

        public void OnPost()
        {
            //save it to our pet list later
            Debug.WriteLine(Pet.Name);
            Debug.WriteLine(Pet.City);
            Debug.WriteLine(Pet.AgeInMonths);

            Debug.WriteLine(Pet.IsVaccinated);
            Debug.WriteLine(Pet.PetType);
        }
    }
}
