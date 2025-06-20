using Solvo_Core.Models;
using Solvo_Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Repository.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetByFiltered(int? categoryId = null, List<int?> brandIdList = null, bool? inStock = null, (decimal? minPrice, decimal? maxPrice)? priceRange = null, bool? orderByPrice = null);
    }
}
