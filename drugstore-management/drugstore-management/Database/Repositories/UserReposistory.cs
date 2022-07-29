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

        public static List<Owner> GetAllOwners()
        {
            List<Owner> owners = new List<Owner>();

            foreach (User user in Users)
            {
                Owner owner = user as Owner;

                if (owner != null)
                {
                    owners.Add(owner);
                }
            }

            return owners;
        }


        public static List<Druggist> GetAllDruggist()
        {
            List<Druggist> druggists = new List<Druggist>();

            foreach (User user in Users)
            {
                if (user is Druggist)
                {
                    druggists.Add((Druggist)user);
                }
            }

            return druggists;
        }



        public static void Delete(User user)
        {
            Users.Remove(user);
        }
    }
}
