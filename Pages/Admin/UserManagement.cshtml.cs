using DataAccess.Persistence.Interface;
using DataAccess.Persistence.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Security.Claims;

namespace Vehicle_Parking_Management_System.Pages.Admin
{
    [BindProperties]
    public class UserManagementModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserManagementModel(IUnitOfWork unitOfWork, 
                                   UserManager<ApplicationUser> userManager, 
                                   SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IEnumerable<ApplicationUser> users { get; set; }
        public ApplicationUser user { get; set; }
        


        public void OnGet(string id)
        {
            /*var ClaimIdentity = (ClaimsIdentity)User.Identity;
            var claim = ClaimIdentity.FindFirst(ClaimTypes.NameIdentifier);*/

            users = _userManager.Users.ToList();
            if(id != null)
            {
                user = users.Where(u => u.Id == id).FirstOrDefault();
            }
                


        }


        public async Task<IActionResult> OnPost()
        {
            return RedirectToPage();
        }
    }
}
