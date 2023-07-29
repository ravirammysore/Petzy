using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Pet Pet { get; set; }

        public List<SelectListItem> DropDownItems { get; set; }

        public IActionResult OnGet(int id)
        {
            var petInDb = InMemoryDatabase.Pets.Find(p=> p.Id == id);

            if (petInDb == null)
            {
                return NotFound();
            }
           
            Pet = petInDb;
            PopulateDropdown();

            return Page();
        }

        private void PopulateDropdown()
        {
            // Create a new list with hardcoded SelectListItem objects
            DropDownItems = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "Dog" },
                new SelectListItem { Value = "1", Text = "Cat" }
            };
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid is false)
            {
                PopulateDropdown();

                return Page();
            }

            var petInDb = InMemoryDatabase.Pets.Find(p=>p.Id == Pet.Id);
            if (petInDb == null)
                return NotFound();

            petInDb.Id = Pet.Id;
            petInDb.Name = Pet.Name;
            petInDb.City = Pet.City;
            petInDb.AgeInMonths = Pet.AgeInMonths;
            petInDb.IsVaccinated = Pet.IsVaccinated;
            petInDb.PetType = Pet.PetType;

            return RedirectToPage("./Index");
        }
    }
}