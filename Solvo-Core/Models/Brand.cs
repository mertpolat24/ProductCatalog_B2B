using Solvo_Core.Abstract;

namespace Solvo_Core.Models
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
