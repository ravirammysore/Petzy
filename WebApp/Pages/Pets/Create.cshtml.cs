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
        public List<SelectListItem> DropDownItems { get; set; }

        public IActionResult OnGet()
        {            
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

        [BindProperty]
        public Pet Pet { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pets.Add(Pet);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
