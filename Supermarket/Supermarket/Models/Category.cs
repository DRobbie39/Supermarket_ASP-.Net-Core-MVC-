using System.ComponentModel.DataAnnotations;

namespace Supermarket.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty; //Khởi tạo thuộc tính Name là rỗng
        public string? Description { get; set; } = string.Empty; //Khởi tạo thuộc tính Description là rỗng
    }
}
