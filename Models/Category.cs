using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Library.Models
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "You have to provide a valid Category Name.")]
        public string Name { get; set; }

        [ValidateNever]
        public List<Book> Books { get; set; }

    }
}
