namespace WebApp.Models
{
    public class Breed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public double AverageWeight { get; set; }
        public int AverageLifeSpan { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
