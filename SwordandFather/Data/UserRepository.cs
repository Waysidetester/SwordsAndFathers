using SwordandFather.Models;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordandFather.Data
{
    public class UserRepository
    {
        static List<User> _users = new List<User>();

        public User AddUser(string username, string password)
        {
            var newUser = new User(username, password);

            newUser.Id = _users.Count + 1;

            _users.Add(newUser);

            return newUser;
        }
        public List<User> GetAll()
        {
            var users = new List<User>();
            var connection = new SqlConnection("Server=localhost;Database=Sword&Father;Trusted_Connection=True;");
            connection.Open();

            var getAllUsersCommand = connection.CreateCommand();
            // or var getAllUsersCommand = new SqlCommand(); -- tell it what command to make
            getAllUsersCommand.CommandText = "SELECT * FROM users";

            var reader = getAllUsersCommand.ExecuteReader();

            while (reader.Read())
            {
                var user = new User(reader["Username"].ToString(), reader["Password"].ToString());
                user.Id = (int)reader["Id"];

                users.Add(user);
            }

            connection.Close();

            return users;
        }
    }
}
