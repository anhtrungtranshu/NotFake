using System.ComponentModel.DataAnnotations;

namespace NotFake.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please input your email")]
        [EmailAddress(ErrorMessage = "Email is not in correct form")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please input your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}