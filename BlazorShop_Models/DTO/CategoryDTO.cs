using System.ComponentModel.DataAnnotations;

namespace BlazorShop_Models.DTO {
    public class CategoryDTO {
         public int Id { get; set; }
         [Required(ErrorMessage = "Please enter name.")]
         public string Name { get; set; }
    }
}