using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wow.Core.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public User(string name, string email, string password) { 
        this.UserId = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
            this.Password = password;
        
        }




    }
}
