using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Pets
{
    public class DetailsModel : PageModel
    {                       
        private readonly DataContext _context;
        public DetailsModel(DataContext context)
        {
            _context = context;
        }

        public Pet Pet { get; set; }
        public IActionResult OnGet(int id)
        {            
            var pet = _context.Pets.FirstOrDefault(p => p.Id == id);
            
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
    }
}
