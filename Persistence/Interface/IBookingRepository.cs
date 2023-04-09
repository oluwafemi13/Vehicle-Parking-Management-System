using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Interface
{
    public interface IBookingRepository: IBaseRepository<Booking>
    {
        new void Update(Booking booking);
    }
}
