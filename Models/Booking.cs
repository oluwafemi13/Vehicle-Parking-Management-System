using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string BookingDuration { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public DateTime DateCreated { get; set; }
        public Payment Payment { get; set; }
        public string Reference { get; set; }
        public string CustomerName { get; set; }
        public string Vehicle { get; set; }

    }
}
