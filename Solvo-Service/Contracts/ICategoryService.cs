using Solvo_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Service.Contracts
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAllCategory();
        Category? GetCategoryById(int id);
        void CreateCategory(Category entity);
        void UpdateCategory(Category entity);
        void DeleteCategory(Category entity);
    }
}
