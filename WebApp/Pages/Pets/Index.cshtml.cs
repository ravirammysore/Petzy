using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Pets
{
    public class IndexModel : PageModel
    {
        public string FirstPetName { get; set; }
        public string SecondPetName { get; set; }
        public void OnGet()
        {
            FirstPetName = "Fluffy";
            SecondPetName = "Bella";
        }
    }
}