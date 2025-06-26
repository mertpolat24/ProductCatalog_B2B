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
    public class UserRepository: RepositoryBase<User>, IUserRepository
    {
        private readonly RepositoryContext _context;

        public UserRepository(RepositoryContext context) : base(context)
        {
        }

        public void Create(User entity)
        {
            _context.Users.Add(entity);   
            _context.SaveChanges();

        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<User> FindAll()
        {
            return _context.Users.AsQueryable();
        }

        public User? FindById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
        }
    }
}
