using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Interface
{
    public interface IUnitOfWork: IDisposable
    {
        void Commit();
        IBookingRepository Booking { get; }
        IVehicleRepository Vehicle { get; }
        IParkingSlotRepository Parking { get; }
        IVehicleCategoryRepository Category { get; }
        IPaymentRepository Payment { get; }
        IVehicleOwnerRepository VehicleOwner { get; }

    }
}
