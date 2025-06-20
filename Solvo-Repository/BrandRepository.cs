using Solvo_Core.Models;
using Solvo_Repository.Base;
using Solvo_Repository.Context;
using Solvo_Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Repository
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(RepositoryContext context) : base(context)
        {
        }
    }
}
