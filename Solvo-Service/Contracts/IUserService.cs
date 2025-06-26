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
        void Create(User user);
        bool IsEmailTaken(string email);
        List<User> GetAll();
        User? GetById(string id);
        bool PasswordSignIn(string email, string password);

    }

}
