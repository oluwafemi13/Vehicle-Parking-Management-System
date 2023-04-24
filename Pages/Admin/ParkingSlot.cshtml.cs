using DataAccess.Persistence.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using System.ComponentModel.DataAnnotations;

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
            
            public string? SlotName { get; set; }
           
           
            public string? SlotType { get; set; }
            
            public int SlotNumber { get; set; }

            
            public string? Status { get; set; }

           
        }

        public InputModel slot { get; set; }
        public ParkingSlot Slot { get; set; }

        public IEnumerable<ParkingSlot> slots { get; set; }
        public void OnGet(int id)
        {
            //var check =  _unitOfWork.Parking.GetById(id);
            
            slots = _unitOfWork.Parking.GetAll();
        }
        public async Task OnGetEdit(int id)
        {

            Slot = await _unitOfWork.Parking.Get(x => x.Id == id);
        }

        public async Task<IActionResult> OnPostEdit(int id)
        {

           
            return RedirectToPage("ParkingSlot");
        }

       
        public IActionResult OnPostAdd()
        {
            
            var selected= Request.Form["Status"].ToString();
            
                var Slot = new ParkingSlot();
                Slot.Status = selected;
                Slot.SlotNumber = slot.SlotNumber;
                Slot.SlotName = slot.SlotName;
                Slot.Id = slot.Id;
                Slot.SlotType = slot.SlotType;
                _unitOfWork.Parking.AddAsync(Slot);
                _unitOfWork.Commit();
                return RedirectToPage("ParkingSlot");
        }

       

        public IActionResult OnPostDelete(int id)
        {
            
            var found = _unitOfWork.Parking.GetById(slot.Id);
            return RedirectToPage("ParkingSlot");
        }
    }
}
