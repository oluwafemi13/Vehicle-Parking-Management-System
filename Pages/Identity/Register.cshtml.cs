using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Vehicle_Parking_Management_System.Pages.DTO;

namespace Vehicle_Parking_Management_System.Pages.Identity
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;

        public RegisterModel(UserManager<IdentityUser> userManager, 
                             RoleManager<IdentityRole> roleManager,
                             ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        public Register register { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
