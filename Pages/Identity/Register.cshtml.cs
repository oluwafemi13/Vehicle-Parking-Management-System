using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vehicle_Parking_Management_System.Pages.DTO;

namespace Vehicle_Parking_Management_System.Pages.Identity
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        public Register register { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
