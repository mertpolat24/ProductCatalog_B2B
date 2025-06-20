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
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        public void CreateCategory(Category entity)
        {
            _manager.CategoryRepository.Create(entity);
            _manager.Save();
        }

        public void DeleteCategory(Category entity)
        {
            _manager.CategoryRepository.Delete(entity);
            _manager.Save();
        }

        public IQueryable<Category> GetAllCategory()
        {
            return _manager.CategoryRepository.FindAll();
        }

        public Category? GetCategoryById(int id)
        {
            return _manager.CategoryRepository.FindById(id);
        }

        public void UpdateCategory(Category entity)
        {
            _manager.CategoryRepository.Update(entity);
            _manager.Save();
        }
    }
}
