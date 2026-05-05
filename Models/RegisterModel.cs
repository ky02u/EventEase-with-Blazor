using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; } = "";
    }
}