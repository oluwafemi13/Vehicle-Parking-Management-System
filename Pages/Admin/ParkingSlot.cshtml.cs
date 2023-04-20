using DataAccess.Persistence.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace Vehicle_Parking_Management_System.Pages.Admin
{
    [BindProperties]
    public class ParkingSlotModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _SignInManager;

        public ParkingSlotModel(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _SignInManager = signInManager;
        }

        public IEnumerable<ParkingSlot> slot { get; set; }
        public void OnGet()
        {
            slot = _unitOfWork.Parking.GetAll();
        }
    }
}
