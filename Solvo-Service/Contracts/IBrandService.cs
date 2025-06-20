using Solvo_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Service.Contracts
{
    public interface IBrandService
    {
        IQueryable<Brand> GetAllBrands();
        Brand? GetBrandById(int id);
        void CreateBrand(Brand entity);
        void UpdateBrand(Brand entity);
        void DeleteBrand(Brand entity);
    }
}
