using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VehicleOwner
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Avatar { get; set; }
        public string UserName { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerPassword { get; set; }
        public string Status { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ApplicationUser user { get; set; }


    }
}
