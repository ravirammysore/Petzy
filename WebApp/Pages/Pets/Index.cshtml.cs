using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;
using System.Collections.Generic;

namespace WebApp.Pages.Pets
{
    public class IndexModel : PageModel
    {
        public List<Pet> Pets { get; set; }

        public void OnGet()
        {
            Pets = new List<Pet>
            {
                new Pet { Id = 1, Name = "Fluffy", City = "San Francisco",
                    IsVaccinated = true, AgeInMonths = 4, PetType = PetType.Cat },

                new Pet { Id = 2, Name = "Bella", City = "San Francisco",
                    IsVaccinated = true, AgeInMonths = 6, PetType = PetType.Dog },
                
                new Pet { Id = 3, Name = "Spot", City = "Chicago",
                    IsVaccinated = false, AgeInMonths = 12,  PetType = PetType.Cat }
                
                // Add more pets as needed...
            };
        }
    }
}