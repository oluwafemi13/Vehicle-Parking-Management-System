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
    public class ParkingSlotRepository : BaseRepository<ParkingSlot>, IParkingSlotRepository
    {
        private readonly DatabaseContext _db;
        public ParkingSlotRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public new void  Update(ParkingSlot parkingSlot)
        {
            _db.Entry(parkingSlot).State = EntityState.Modified;
        }
    }
}
