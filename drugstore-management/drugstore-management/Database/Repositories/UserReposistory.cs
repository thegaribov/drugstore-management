using drugstore_management.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstore_management.Database.Repositories
{
    class UserRepository
    {
        private static int _idCounter;

        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }


        private static List<User> Users { get; set; } = new List<User>()
        {
          
        };

        public static User AddUser(User user)
        {
            Users.Add(user);
            return user;
        }

        public static List<User> GetAll()
        {
            return Users;
        }

        public static void Delete(User user)
        {
            Users.Remove(user);
        }
    }
}
