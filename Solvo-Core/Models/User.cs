using Microsoft.AspNetCore.Identity;
using Solvo_Core.Abstract;
using Solvo_Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solvo_Core.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; } 
        public string PasswordHash { get; set; }
        public Roles Roles { get; set; }
    }
}
