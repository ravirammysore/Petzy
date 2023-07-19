public class Pet
{
    public int Id { get; set; }    
    public string Name { get; set; }
    public string City { get; set; }
    public bool IsVaccinated { get; set; }
    public int AgeInMonths { get; set; }
    public PetType PetType { get; set; }
}

public enum PetType
{
    Dog,
    Cat   
}