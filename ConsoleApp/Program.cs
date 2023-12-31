﻿// Create a list and add the pets to it
List<Pet> pets = new List<Pet>
{
    new Pet { Id = 1, Name = "Fluffy", City  = "San Francisco", 
        IsVaccinated = true, AgeInMonths = 4, PetType = PetType.Dog },

    new Pet { Id = 2, Name = "Bella", City = "San Francisco", 
        IsVaccinated = true, AgeInMonths = 6,  PetType = PetType.Dog },

    new Pet { Id = 3, Name = "Spot", City = "Chicago", 
        IsVaccinated = false, AgeInMonths = 12,  PetType = PetType.Cat },

    new Pet { Id = 4, Name = "Max", City = "Chicago", 
        IsVaccinated = false, AgeInMonths = 6 , PetType = PetType.Dog},

    new Pet { Id = 5, Name = "Charlie", City = "Chicago", 
        IsVaccinated = true, AgeInMonths = 7,  PetType = PetType.Dog },

    new Pet { Id = 6, Name = "Daisy", City = "San Francisco", 
        IsVaccinated = false, AgeInMonths = 11,  PetType = PetType.Cat }
};


while (true)
{
    Console.WriteLine();

    Console.WriteLine("******************** Welcome to the pet store ***************");
    Console.WriteLine("1. Display all pets");
    Console.WriteLine("2. Display pups only");
    Console.WriteLine("3. Display vaccinated pups");
    Console.WriteLine("4. Mark a pet as vaccinated");
    Console.WriteLine("5. Exit");
    Console.WriteLine("*************************************************************");
    Console.Write("Choose your option: ");

    string option = Console.ReadLine();

    Console.Clear();

    switch (option)
    {
        case "1":           
            DisplayPets(pets);
            break;

        case "2":
            var pups = pets.Where(pet => pet.AgeInMonths < 6).ToList();
            DisplayPets(pups);
            break;

        case "3":
            var vaccinatedPets = pets.Where(pet => pet.IsVaccinated).ToList();
            DisplayPets(vaccinatedPets);
            break;

        case "4":
            Console.Write("Enter the ID of the pet to vaccinate: ");

            try
            {
                int id = int.Parse(Console.ReadLine());

                var petToVaccinate = pets.Find(pet => pet.Id == id);

                if (petToVaccinate is not null)
                    petToVaccinate.IsVaccinated = true;
                else
                    Console.WriteLine("Pet not found!");

                DisplayPets(pets);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

void DisplayPets(List<Pet> pets)
{
    Console.WriteLine();

    Console.WriteLine($"{"Id",-8}{"Name",-16}{"City",-16}{"Is Vaccinated",-16}{"Age in months",-16}{"Type",-16}");

    foreach (Pet pet in pets)
        Console.WriteLine($"{pet.Id,-8}{pet.Name,-16}{pet.City,-16}" +
            $"{pet.IsVaccinated,-16}{pet.AgeInMonths + " months",-16}{pet.PetType.ToString(),-8}");
}


