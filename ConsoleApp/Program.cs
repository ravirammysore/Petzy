// Create a list and add the pets to it
List<Pet> pets = new List<Pet>
{
    new Pet { Id = 1, Name = "Fluffy", City = "San Francisco", IsVaccinated = true },
    new Pet { Id = 2, Name = "Spot", City = "New York", IsVaccinated = false },
    new Pet { Id = 3, Name = "Bella", City = "Los Angeles", IsVaccinated = true },
    new Pet { Id = 4, Name = "Max", City = "Chicago", IsVaccinated = false }
};

// Display the pets
foreach (Pet pet in pets)
    Display(pet);

void Display(Pet pet)
{
    Console.WriteLine($"Id: {pet.Id}");
    Console.WriteLine($"Name: {pet.Name}");
    Console.WriteLine($"City: {pet.City}");
    Console.WriteLine($"Is Vaccinated: {pet.IsVaccinated}");
    Console.WriteLine();
}
