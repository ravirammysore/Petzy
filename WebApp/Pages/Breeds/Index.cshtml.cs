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
    public class IndexModel : PageModel
    {
        private readonly WebApp.Data.DataContext _context;

        public IndexModel(WebApp.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Breed> Breeds { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Breeds != null)
            {
                Breeds = await _context.Breeds.ToListAsync();
            }
        }
    }
}
