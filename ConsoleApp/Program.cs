namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Create the first pet
        Pet pet1 = new Pet();
        pet1.Id = 1;
        pet1.Name = "Fluffy";
        pet1.City = "San Francisco";
        pet1.IsVaccinated = true;

        // Create the second pet
        Pet pet2 = new Pet();
        pet2.Id = 2;
        pet2.Name = "Spot";
        pet2.City = "New York";
        pet2.IsVaccinated = false;

        // Display the pets
        DisplayPet(pet1);
        DisplayPet(pet2);

        Console.ReadKey();
    }

    static void DisplayPet(Pet pet)
    {
        Console.WriteLine($"Id: {pet.Id}");
        Console.WriteLine($"Name: {pet.Name}");
        Console.WriteLine($"City: {pet.City}");
        Console.WriteLine($"Is Vaccinated: {pet.IsVaccinated}");
        Console.WriteLine();
    }
}