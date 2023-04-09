using DataAccess.Data;
using DataAccess.Persistence.Interface;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Repository
{
    public class BookingRepository : BaseRepository<Booking>, IBookingRepository
    {
        private readonly DatabaseContext _db;

        public BookingRepository(DatabaseContext db):base(db) { _db = db; }
       

        public new void Update(Booking booking)
        {
            _db.Entry(booking).State = EntityState.Modified;
        }
    }
}
