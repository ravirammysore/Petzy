using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using System.Collections.Generic;
using WebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages.Pets
{
    public class IndexModel : PageModel
    {
        public List<Pet> Pets { get; set; }
        public void OnGet()
        {
            string server = "(localdb)\\mssqllocaldb";
            string database = "PetzyDB";
            string trustedConnection = "True";

            string connectionString = $"Server={server};Database={database};Trusted_Connection={trustedConnection};";

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var context = new DataContext(optionsBuilder.Options);
            
            Pets = context.Pets.ToList();
        }
    }
}