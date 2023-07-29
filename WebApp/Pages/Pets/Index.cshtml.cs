using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using System.Collections.Generic;
using WebApp.Data;

namespace WebApp.Pages.Pets
{
    public class IndexModel : PageModel
    {
        public List<Pet> Pets { get; set; }

        public void OnGet()
        {
            Pets = InMemoryDatabase.Pets;           
        }
    }
}