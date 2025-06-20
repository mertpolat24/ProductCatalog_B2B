using Solvo_Core.Models;
using Solvo_Repository.Context;
using Solvo_Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly RepositoryContext _context;

        public ProductRepository(RepositoryContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Product> GetByFiltered(int? categoryId = null, List<int?> brandIdList = null, bool? inStock = null, (decimal? minPrice, decimal? maxPrice)? priceRange = null, bool? orderByPrice = null)
        {
            var query = _context.Products.AsQueryable();

            if (categoryId.HasValue)
                query = query.Where(c => c.CategoryId == categoryId.Value);
            if (brandIdList is not null)
                foreach (var brand in brandIdList)
                {
                    query.Where(c => c.Brand.Id == brand);
                }
            if (inStock == true)
                query = query.Where(c => c.Stock > 0);
            if (priceRange.Value.minPrice is not null)
                query = query.Where(c => c.Price > priceRange.Value.minPrice);
            if (priceRange.Value.maxPrice is not null)
                query = query.Where(c => c.Price < priceRange.Value.maxPrice);

            query = orderByPrice.Value
                ? query.OrderBy(p => p.Price)
                : query.OrderByDescending(p => p.Price);

            return query;
        }
    }
}
