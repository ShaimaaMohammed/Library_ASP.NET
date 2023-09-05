using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }

        [DisplayName("Author Name")]
        [Required(ErrorMessage = "You have to provide a valid Author Name.")]
        public string AuthorName { get; set; }
        
        [DisplayName("Title")]
        [Required(ErrorMessage = "You have to provide a valid Title.")]
        public string Title { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "You have to provide a valid Description.")]
        public string Description { get; set; }

        [DisplayName("PDF")]
        [Required(ErrorMessage = "You have to provide a valid PDF.")]
        public string PdfPath { get; set; }

        [DisplayName("Image")]
        [ValidateNever]
        public string ImagePath { get; set; }

        //[Range(1, double.MaxValue, ErrorMessage = "Select a vaild department.")]
        //[DisplayName("Department")]
        public int AuthorId { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Select a vaild Category.")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }

        [ValidateNever]
        public Author Author { get; set; }
        
        [ValidateNever]
        public Category Category { get; set; }
    }
}
