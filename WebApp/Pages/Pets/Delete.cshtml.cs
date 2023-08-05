using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class DeleteModel : PageModel
    {
        public Pet Pet { get; set; }
        
        private readonly DataContext _context;
        public DeleteModel(DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            var pet = _context.Pets.FirstOrDefault(m => m.Id == id);

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
            var pet = _context.Pets.Find(id);

            if (pet is not null)
            {
                Pet = pet;
                _context.Pets.Remove(pet);
                _context.SaveChanges();
            }

            return RedirectToPage("./Index");
        }
    }
}
