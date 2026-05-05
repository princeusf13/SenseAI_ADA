using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class UserRegistrationViewModel
    {
        // ViewModel used for handling user registration data from the UI
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; } 
    }
}
