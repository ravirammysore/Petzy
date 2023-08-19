using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{   

    public class Pet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 15 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "City must be between 2 and 15 characters.")]
        public string City { get; set; }

        [Display(Name = "Is Vaccinated")]
        public bool IsVaccinated { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100 months.")]
        [Display(Name = "Age (Months)")]
        [DisplayFormat(DataFormatString = "{0:D2}")]
        public int AgeInMonths { get; set; }

        [Display(Name = "Type of Pet")]
        public PetType PetType { get; set; }
        public int? BreedID { get; set; }        
        public Breed Breed { get; set; }
    }


    public enum PetType
    {
        Dog,
        Cat
    }
}