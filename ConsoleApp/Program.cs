// Create a list and add the pets to it
List<Pet> pets = new List<Pet>
{
    new Pet { Id = 1, Name = "Fluffy", City = "San Francisco", 
        IsVaccinated = true, AgeInMonths = 4 },

    new Pet { Id = 2, Name = "Bella", City = "San Francisco", 
        IsVaccinated = true, AgeInMonths = 6 },

    new Pet { Id = 3, Name = "Spot", City = "Chicago", 
        IsVaccinated = false, AgeInMonths = 12 },

    new Pet { Id = 4, Name = "Max", City = "Chicago", 
        IsVaccinated = false, AgeInMonths = 6 },

    new Pet { Id = 5, Name = "Charlie", City = "Chicago", 
        IsVaccinated = true, AgeInMonths = 7 },

    new Pet { Id = 6, Name = "Daisy", City = "San Francisco", 
        IsVaccinated = false, AgeInMonths = 11 }
};


while (true)
{
    Console.WriteLine("******************** Welcome to the pet store ***************");
    Console.WriteLine("1. Display all pets");
    Console.WriteLine("2. Display pups only");
    Console.WriteLine("3. Display vaccinated pups");
    Console.WriteLine("4. Mark a pet as vaccinated");
    Console.WriteLine("5. Exit");
    Console.WriteLine("*************************************************************");
    Console.Write("Choose your option: ");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            foreach (Pet pet in pets)
                Display(pet);
            break;
        case "2":
            foreach (Pet pet in pets)
                if (pet.AgeInMonths < 6)
                    Display(pet);
            break;
        case "3":
            foreach (Pet pet in pets)
                if (pet.IsVaccinated)
                    Display(pet);
            break;
        case "4":
            Console.Write("Enter the ID of the pet to vaccinate: ");
            int id = int.Parse(Console.ReadLine());
            foreach (Pet pet in pets)
                if (pet.Id == id)
                    pet.IsVaccinated = true;
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}


void Display(Pet pet)
{
    Console.WriteLine($"Id: {pet.Id}");
    Console.WriteLine($"Name: {pet.Name}");
    Console.WriteLine($"City: {pet.City}");
    Console.WriteLine($"Is Vaccinated: {pet.IsVaccinated}");
    Console.WriteLine($"{pet.AgeInMonths} months old");
    Console.WriteLine();
}
