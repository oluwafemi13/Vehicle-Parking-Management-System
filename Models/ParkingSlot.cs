using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ParkingSlot
    {
        
        public int Id { get; set; }
        public string SlotName { get; set; }
        public string SlotType { get; set; }
        public int SlotNumber { get; set; }
        public string Status { get; set; }
        
       


    }
}
