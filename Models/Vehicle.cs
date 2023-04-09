using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string PlateNumber { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int? VehicleCategoryId { get; set; }
        public VehicleCategory category { get; set; }
        public VehicleOwner Owner { get; set; }


    }
}
