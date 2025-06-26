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
    }
}
