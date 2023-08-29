using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using System.Collections.Generic;
using WebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages.Pets
{
    public class IndexModel : PageModel
    {        
        private readonly DataContext _context;
        public IndexModel(DataContext context)
        {
            _context = context;
        }
        public List<Pet> Pets { get; set; }
        public void OnGet()
        {           
            Pets = _context.Pets.Include(p=>p.Breed).ToList();
        }
    }
}