// Create the first pet
Pet pet1 = new Pet();
pet1.Id = 1;
pet1.Name = "Fluffy";
pet1.City = "San Francisco";
pet1.IsVaccinated = true;

// Display the first pet
DisplayPetInfo(pet1);

// Create the second pet
Pet pet2 = new Pet();
pet2.Id = 2;
pet2.Name = "Spot";
pet2.City = "New York";
pet2.IsVaccinated = false;

// Display the second pet
DisplayPetInfo(pet2);

void DisplayPetInfo(Pet pet1)
{
    Console.WriteLine($"Id: {pet1.Id}");
    Console.WriteLine($"Name: {pet1.Name}");
    Console.WriteLine($"City: {pet1.City}");
    Console.WriteLine($"Is Vaccinated: {pet1.IsVaccinated}");
    Console.WriteLine();
}