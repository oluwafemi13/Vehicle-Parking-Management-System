using DataAccess.Persistence.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace Vehicle_Parking_Management_System.Pages.Admin
{
    [BindProperties]
    public class DashboardModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //public Booking Bookings { get; set; }
        public int Bookings { get; set; }
        public int TotalParkingSlots { get; set; }
        public int TotalVehicles { get; set; }
        public int TotalVehicleOwners { get; set; }
        public async void OnGet()
        {
            var Booking = _unitOfWork.Booking.GetAllAsync().GetAwaiter().GetResult();
            Bookings= Booking.Count();
            TotalParkingSlots = 500;
            TotalVehicles = _unitOfWork.Vehicle.GetAllAsync().GetAwaiter().GetResult().Count();
            var vehicleOwner = _unitOfWork.VehicleOwner.GetAllAsync().GetAwaiter().GetResult();
            TotalVehicleOwners= vehicleOwner.Count();



        }
    }
}
