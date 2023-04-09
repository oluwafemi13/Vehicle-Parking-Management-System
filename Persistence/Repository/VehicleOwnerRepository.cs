using DataAccess.Data;
using DataAccess.Persistence.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Repository
{
    public class VehicleOwnerRepository : BaseRepository<VehicleOwner>, IVehicleOwnerRepository
    {
        private readonly DatabaseContext _db;
        public VehicleOwnerRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }
    }
}
