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

        public List<SelectListItem> DropDownItems { get; set; }

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
            PopulateDropdown();

            return Page();
        }

        private void PopulateDropdown()
        {
            // Create a new list with hardcoded SelectListItem objects
            DropDownItems = new List<SelectListItem>
            {
                new SelectListItem { Value = "0", Text = "Male" },
                new SelectListItem { Value = "1", Text = "Female" }
            };
        }

        public IActionResult OnPost()
        {
            ModelState.Remove("Pet.Breed");
            if (ModelState.IsValid is false)
            {
                PopulateDropdown();
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