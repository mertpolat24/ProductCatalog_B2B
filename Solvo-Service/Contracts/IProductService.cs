using Solvo_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Service.Contracts
{
    public interface IProductService
    {
        IQueryable<Product> GetAllProduct();
        Product? GetProductById(int id);
        void CreateProduct(Product entity);
        void UpdateProduct(Product entity);
        void DeleteProduct(Product entity);
    }
}
