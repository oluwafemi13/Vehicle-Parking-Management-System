using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstNmae { get; set; }
        public string LastName { get; set; }
        public string? Avatar { get; set; }
        /*[ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role role { get; set; }*/
        /*public ICollection<VehicleCategory> VehicleCategory { get; set; }
        public ICollection<VehicleOwner> VehicleOwner { get; set; }
        public ICollection<Payment> Payment { get; set; }*/

    }
}
