using DataAccess.Persistence.Interface;
using DataAccess.Persistence.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace Vehicle_Parking_Management_System.Pages.Admin
{
    public class BookingModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ParkingSlot> slot;
        public void OnGet()
        {
            slot = _unitOfWork.Parking.GetAll();
        }
    }
}
