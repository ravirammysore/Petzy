using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Breed
    {
        public Breed()
        {
            Pets = new List<Pet>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Average Weight (Kilos)")]
        public double AverageWeight { get; set; }
        [Display(Name = "Average Lifespan (Years)")]
        public int AverageLifeSpan { get; set; }
        public ICollection<Pet> Pets { get; set; }
    }
}
