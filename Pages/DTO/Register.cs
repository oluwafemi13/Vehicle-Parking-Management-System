using System.ComponentModel.DataAnnotations;

namespace Vehicle_Parking_Management_System.Pages.DTO
{
    public class Register
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LasttName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? UserName { get; set; }
    }
}
