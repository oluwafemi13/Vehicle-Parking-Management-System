using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

    public class Payment
    {
        public int PaymentId { get; set; }
        public Decimal AmountDue { get; set; }
        public Decimal AmountPaid { get; set; }
        public string Status { get; set; }
        public string PaidBy { get; set; }
        public DateTime DatePaid { get; set; }
        public ApplicationUser user { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }

    }

