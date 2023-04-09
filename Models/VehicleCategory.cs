using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VehicleCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ApplicationUser user { get; set; }
        public Vehicle Vehicle { get; set; }
        
    }
}
