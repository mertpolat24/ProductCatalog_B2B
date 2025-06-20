using Microsoft.AspNetCore.Identity;
using Solvo_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Service.Contracts
{
    public interface IUserService
    {
        User? GetById(string userId);
        List<User> GetAll();
        IdentityResult Create(User user, string password);
        SignInResult PasswordSignIn(string email, string password, bool rememberMe);
        void SignOut();
        bool IsEmailTaken(string email);
    }
}
