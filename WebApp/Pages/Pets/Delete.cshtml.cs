using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class DeleteModel : PageModel
    {
        public Pet Pet { get; set; }

        public IActionResult OnGet(int id)
        {
            var pet = InMemoryDatabase.Pets.FirstOrDefault(p => p.Id == id);

            if (pet == null)
            {
                return NotFound();
            }
            else
            {
                Pet = pet;
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var pet = InMemoryDatabase.Pets.FirstOrDefault(p => p.Id == id);

            if (pet == null)
            {
                return NotFound();
            }
            else
            {
                InMemoryDatabase.Pets.Remove(pet);
            }
            return RedirectToPage("./Index");
        }
    }

}
