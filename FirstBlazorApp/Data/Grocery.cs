using System.ComponentModel.DataAnnotations;
namespace FirstBlazorApp.Data

{
    public class Grocery
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name should be less than 20 characters")]
        public string Name { get; set; }
        [Required]
        [Range(1, 10000, ErrorMessage = "Price should be between 1 and 10,000")]
        public float Price { get; set; }
    }
}
