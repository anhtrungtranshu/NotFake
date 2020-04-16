using System.ComponentModel.DataAnnotations;

namespace NotFake.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }
}