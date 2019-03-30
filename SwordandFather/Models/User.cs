using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordandFather.Models
{
    public class User
    {
        public string Username { get; }
        public string Password { get; }
        public int Id { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
