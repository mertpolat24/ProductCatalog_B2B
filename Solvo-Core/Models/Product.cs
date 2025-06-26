using Solvo_Core.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Solvo_Core.Models
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "Ürün adı zorunludur.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur.")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Fiyat zorunludur.")]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        [Required(ErrorMessage = "Görsel yolu zorunludur.")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Kategori seçilmelidir.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Marka seçilmelidir.")]
        public int BrandId { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }

    }
}
