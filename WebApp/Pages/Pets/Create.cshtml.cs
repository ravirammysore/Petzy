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
        [BindProperty]
        public Pet Pet { get; set; }

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

        public IActionResult OnPost()
        {
            if(ModelState.IsValid is false)
            {
                PopulateDropdown();

                return Page();
            }
            
            InMemoryDatabase.Pets.Add(Pet);

            return RedirectToPage("./Index");
        }
    }
}
