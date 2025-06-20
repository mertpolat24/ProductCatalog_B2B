using Microsoft.AspNetCore.Identity;
using Solvo_Core.Models;
using Solvo_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Service
{
    using Microsoft.AspNetCore.Identity;
    using Solvo_Core.Models;
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(UserManager<User> userManager,
                           SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public User? GetById(string userId)
        {
            return _userManager.FindByIdAsync(userId).GetAwaiter().GetResult();
        }

        public List<User> GetAll()
        {
            return _userManager.Users.ToList();
        }

        public IdentityResult Create(User user, string password)
        {
            return _userManager.CreateAsync(user, password).GetAwaiter().GetResult();
        }

        public SignInResult PasswordSignIn(string email, string password, bool rememberMe)
        {
            var user = _userManager.FindByEmailAsync(email).GetAwaiter().GetResult();
            if (user == null)
                return SignInResult.Failed;

            return _signInManager.PasswordSignInAsync(user, password, rememberMe, false)
                                  .GetAwaiter().GetResult();
        }

        public void SignOut()
        {
            _signInManager.SignOutAsync().GetAwaiter().GetResult();
        }

        public bool IsEmailTaken(string email)
        {
            return _userManager.FindByEmailAsync(email).GetAwaiter().GetResult() != null;
        }
    }
}
