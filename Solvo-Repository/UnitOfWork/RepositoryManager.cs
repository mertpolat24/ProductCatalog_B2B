using Solvo_Repository.Context;
using Solvo_Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Repository.UnitOfWork
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productrepository;
        private readonly IBrandRepository _brandRepository;
        private readonly ICategoryRepository _categoryRepository;

        public RepositoryManager(RepositoryContext context, IProductRepository productrepository, IBrandRepository brandRepository, ICategoryRepository categoryRepository)
        {
            _context = context;
            _productrepository = productrepository;
            _brandRepository = brandRepository;
            _categoryRepository = categoryRepository;
        }

        public IBrandRepository BrandRepository => _brandRepository;

        public ICategoryRepository CategoryRepository => _categoryRepository;

        public IProductRepository ProductRepository => _productrepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
