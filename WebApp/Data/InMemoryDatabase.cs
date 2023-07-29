using WebApp.Models;

namespace WebApp.Data
{
    public static class InMemoryDatabase
    {
        public static List<Pet> Pets { get; set; } = new List<Pet>
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
