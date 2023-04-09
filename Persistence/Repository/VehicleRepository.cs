using DataAccess.Data;
using DataAccess.Persistence.Interface;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Repository
{
    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        private readonly DatabaseContext _db;
        public VehicleRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public new void Update(Vehicle vehicle)
        {
            _db.Entry(vehicle).State = EntityState.Modified;
        }
    }
}
