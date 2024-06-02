using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace TaskBySibers.Models
{
    public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class RegisterUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

    }

    public class User : IdentityUser
    {
        //public string UserName { get; set; }
        //public string Password { get; set; }


    }
}