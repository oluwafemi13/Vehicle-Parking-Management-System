using DataAccess.Data;
using DataAccess.Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _db;

        public UnitOfWork(DatabaseContext db)
        {
            _db = db;
             Booking = new BookingRepository(_db);
             Vehicle = new VehicleRepository(_db);
             Parking = new ParkingSlotRepository(_db);
             VehicleOwner= new VehicleOwnerRepository(_db);
             Category = new VehicleCategoryRepository(_db);
             Payment= new PaymentRepository(_db);
        }

        public IBookingRepository Booking { get; private set; }
        public IVehicleRepository Vehicle { get; private set; }
        public IParkingSlotRepository Parking { get; private set; }
        public IVehicleCategoryRepository Category { get; private set; }
        public IPaymentRepository Payment { get; private set; }
        public IVehicleOwnerRepository VehicleOwner { get; private set; }

        public void Commit()
        {
            _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
