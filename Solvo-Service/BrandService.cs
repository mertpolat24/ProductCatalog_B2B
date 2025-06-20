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
    public class BrandService : IBrandService
    {
        private readonly IRepositoryManager _manager;

        public BrandService(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public void CreateBrand(Brand entity)
        {
            _manager.BrandRepository.Create(entity);
            _manager.Save();
        }

        public void DeleteBrand(Brand entity)
        {
            _manager.BrandRepository.Delete(entity);
            _manager.Save();
        }

        public IQueryable<Brand> GetAllBrands()
        {
            return _manager.BrandRepository.FindAll();
        }

        public Brand? GetBrandById(int id)
        {
            return _manager.BrandRepository.FindById(id);
        }

        public void UpdateBrand(Brand entity)
        {
            _manager.BrandRepository.Update(entity);
            _manager.Save();
        }
    }
}
