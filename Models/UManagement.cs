using Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vehicle_Parking_Management_System.Models
{
    public class UManagement
    {
        public int Id { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser UserId { get; set; }

        public string? UserCategory { get; set; } //Admin Customer
        public string Status { get; set; } //Active Inactive
    }
}
