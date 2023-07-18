
// Create the pets
Pet pet1 = new Pet();
pet1.Id = 1;
pet1.Name = "Fluffy";
pet1.City = "San Francisco";
pet1.IsVaccinated = true;

Pet pet2 = new Pet();
pet2.Id = 2;
pet2.Name = "Spot";
pet2.City = "New York";
pet2.IsVaccinated = false;

Pet pet3 = new Pet();
pet3.Id = 3;
pet3.Name = "Bella";
pet3.City = "Los Angeles";
pet3.IsVaccinated = true;

Pet pet4 = new Pet();
pet4.Id = 4;
pet4.Name = "Max";
pet4.City = "Chicago";
pet4.IsVaccinated = false;

// Create a list and add the pets to it
List<Pet> pets = new List<Pet>();
pets.Add(pet1);
pets.Add(pet2);
pets.Add(pet3);
pets.Add(pet4);

// Display the pets
foreach (Pet pet in pets)
{
    Display(pet);
}

void Display(Pet pet)
{
    Console.WriteLine($"Id: {pet.Id}");
    Console.WriteLine($"Name: {pet.Name}");
    Console.WriteLine($"City: {pet.City}");
    Console.WriteLine($"Is Vaccinated: {pet.IsVaccinated}");
    Console.WriteLine();
}
