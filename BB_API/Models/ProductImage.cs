using System.ComponentModel.DataAnnotations;

namespace BB_API.Models
{
    public class ProductImage
    {
        [Key]
        public int ProductImageId { get; set; }
        [StringLength(250)]
        public string URL { get; set; }
        [Required]
        public int FkProductId { get; set; }

    }
}
