using Solvo_Core.Abstract;
using Solvo_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Core.Models
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
