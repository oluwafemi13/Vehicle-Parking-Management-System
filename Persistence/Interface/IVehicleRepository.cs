using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.Interface
{
    public interface IVehicleRepository: IBaseRepository<Vehicle>
    {
        new void Update(Vehicle vehicle);
    }
}
