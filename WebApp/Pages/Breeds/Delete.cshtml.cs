using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Breeds
{
    public class DeleteModel : PageModel
    {
        private readonly WebApp.Data.DataContext _context;

        public DeleteModel(WebApp.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Breed Breed { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Breeds == null)
            {
                return NotFound();
            }

            var breed = await _context.Breeds.FirstOrDefaultAsync(m => m.Id == id);

            if (breed == null)
            {
                return NotFound();
            }
            else 
            {
                Breed = breed;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Breeds == null)
            {
                return NotFound();
            }
            var breed = await _context.Breeds.FindAsync(id);

            if (breed != null)
            {
                Breed = breed;
                _context.Breeds.Remove(Breed);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
