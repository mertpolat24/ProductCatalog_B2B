using Solvo_Core.Models;
using Solvo_Repository.Context;
using Solvo_Service.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Solvo_Service
{
    public class UserService : IUserService
    {
        private readonly RepositoryContext _context;

        public UserService(RepositoryContext context)   
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public bool IsEmailTaken(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User? Login(string email, string passwordHash)
        {
            return _context.Users
                .FirstOrDefault(u => u.Email == email && u.PasswordHash == passwordHash);
        }
        public bool PasswordSignIn(string email, string password)
        {
            var user = _context.Users.Where(u => u.Email == email)
                                     .FirstOrDefault();
            if (user == null)
                return false;

            var hashedInput = ComputeSha256Hash(password);
            return user.PasswordHash == hashedInput;
        }

        private string ComputeSha256Hash(string rawData)
        {
            using var sha256 = System.Security.Cryptography.SHA256.Create();
            byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(rawData));
            return Convert.ToHexString(bytes); // .NET 5+
        }
        

        public User? GetById(string id)
        {
            return _context.Users.Find(id);
        }
    }
}
