using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        // Data Validation Attribute
        [Required(ErrorMessage = "You have to provide a valid first name.")] 
        [MinLength(2, ErrorMessage = "Name mustn't be less than 2 characters.")]
        public string FristName { get; set; }

        [DisplayName("Second Name")]
        [Required(ErrorMessage = "You have to provide a valid second name.")]   
        [MinLength(2, ErrorMessage = "Name mustn't be less than 2 characters.")]
        public string SecondName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "You have to provide a valid e-mail.")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "You have to provide a valid Password.")]
        public string Password { get; set; }


        [DisplayName("Image")]
        [ValidateNever]
        public string ImagePath { get; set; }
        
        [ValidateNever]
        public List<Book> Books { get; set; }

    }
}
