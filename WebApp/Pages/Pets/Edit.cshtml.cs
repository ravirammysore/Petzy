using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class EditModel : PageModel
    {
        private readonly DataContext _context;
        public EditModel(DataContext context)
        {
            _context = context;
        }        

        public List<SelectListItem> GenderDropDownItems { get; set; }

        public List<SelectListItem> BreedDropDownItems { get; set; }

        [BindProperty]
        public Pet Pet { get; set; }
        public IActionResult OnGet(int id)
        {
            var petInDb = _context.Pets.FirstOrDefault(p => p.Id == id);

            if (petInDb == null)
            {
                return NotFound();
            }
           
            Pet = petInDb;
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

        public IActionResult OnPost()
        {
            ModelState.Remove("Pet.Breed");
            if (ModelState.IsValid is false)
            {
                PopulateGenderDropdown();
                PopulateBreedDropdown();
                return Page();
            }

            _context.Attach(Pet).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetExists(Pet.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
        private bool PetExists(int id)
        {
            return (_context.Pets?.Any(p => p.Id == id)).GetValueOrDefault();
        }
    }
}