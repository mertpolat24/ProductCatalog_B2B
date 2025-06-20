using Solvo_Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Repository.Base
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        IQueryable<T> FindAll();
        T? FindById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
