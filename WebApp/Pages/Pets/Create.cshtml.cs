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
            var petTypeValues = Enum.GetValues(typeof(PetType)).Cast<PetType>();

            DropDownItems = petTypeValues.Select(pt => new SelectListItem
            {
                Value = ((int)pt).ToString(),
                Text = pt.ToString()
            }).ToList();

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
