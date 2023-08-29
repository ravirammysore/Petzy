using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class CreateModel : PageModel
    {
        private readonly DataContext _context;
        public CreateModel(DataContext context)
        {
            _context = context;
        }
        public List<SelectListItem> GenderDropDownItems { get; set; }
        public List<SelectListItem> BreedDropDownItems { get; set; }

        public IActionResult OnGet()
        {
            PopulateGenderDropdown();
            PopulateBreedDropdown();
            return Page();
        }

        private void PopulateGenderDropdown()
        {
            // Create a new list with hardcoded SelectListItem objects
            GenderDropDownItems = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "Male" },
                new SelectListItem { Value = "1", Text = "Female" }
            };
        }
        private void PopulateBreedDropdown()
        {
            BreedDropDownItems = new List<SelectListItem>();

            var defaultOption = new SelectListItem
            {
                Value = "",
                Text = "--Select a Breed--",
                Selected = true,
                Disabled = true
            };

            BreedDropDownItems.Add(defaultOption);

            var breeds = _context.Breeds.OrderBy(b => b.Name).ToList();

            foreach (var breed in breeds)
            {
                var item = new SelectListItem
                {
                    Value = breed.Id.ToString(),
                    Text = breed.Name
                };
                BreedDropDownItems.Add(item);
            }
        }


        [BindProperty]
        public Pet Pet { get; set; }
        public IActionResult OnPost()
        {
            ModelState.Remove("Pet.Breed");

            if (!ModelState.IsValid)
            {
                PopulateGenderDropdown();
                PopulateBreedDropdown();
                return Page();
            }

            _context.Pets.Add(Pet);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
