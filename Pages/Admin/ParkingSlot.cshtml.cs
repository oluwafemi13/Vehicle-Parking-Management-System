using DataAccess.Persistence.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Build.Framework;
using Models;

namespace Vehicle_Parking_Management_System.Pages.Admin
{
    [BindProperties]
    public class ParkingSlotModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _SignInManager;

        public ParkingSlotModel(IUnitOfWork unitOfWork, 
                                UserManager<ApplicationUser> userManager,  
                                SignInManager<ApplicationUser> signInManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _SignInManager = signInManager;
        }

        public class InputModel
        {
            public int Id { get; set; }
            [Required]
            public string SlotName { get; set; }
            [Required]
            public string SlotType { get; set; }
            [Required]
            public int SlotNumber { get; set; }

            [Required]
            public string Status { get; set; }
        }
        


        public InputModel slot { get; set; }

        public IEnumerable<ParkingSlot> slots { get; set; }
        public void OnGet()
        {
            slots = _unitOfWork.Parking.GetAll();
        }

        public async Task<IActionResult> OnPostEdit()
        {
            if(ModelState.IsValid)
            {
                
            }
            return RedirectToPage("ParkingSlot");
        }

        public async Task<IActionResult> OnPostAdd()
        {
            if(ModelState.IsValid)
            {
                var Slot = new ParkingSlot();
                Slot.Status = slot.Status;
                Slot.SlotNumber = slot.SlotNumber;
                Slot.SlotName = slot.SlotName;
                Slot.Id = slot.Id;
                Slot.SlotType = slot.SlotType;
                _unitOfWork.Parking.AddAsync(Slot);
                _unitOfWork.Commit();
                
                
            }
            return RedirectToPage("ParkingSlot");
        }
    }
}
