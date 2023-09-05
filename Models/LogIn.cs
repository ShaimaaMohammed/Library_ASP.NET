using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library.Models
{
    public class LogIn
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "You have to provide a valid Email.")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "You have to provide a valid Password.")]
        public string Password { get; set; }
    }
}
