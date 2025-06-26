using Microsoft.EntityFrameworkCore;
using Solvo_Core.Models;
using Solvo_Repository.UnitOfWork;
using Solvo_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Service
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateProduct(Product entity)
        {
            _manager.ProductRepository.Create(entity);
            _manager.Save();
        }

        public void DeleteProduct(Product entity)
        {
            _manager.ProductRepository.Delete(entity);
            _manager.Save();
        }

        public IQueryable<Product> GetAllProduct()
        {
            return _manager.ProductRepository.FindAll().Include(p => p.Brand).Include(p => p.Category).AsQueryable();

        }

        public Product? GetProductById(int id)
        {
            return _manager.ProductRepository.FindById(id);
        }

        public void UpdateProduct(Product entity)
        {
            _manager.ProductRepository.Update(entity);
            _manager.Save();
        }
    }
}
