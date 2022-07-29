using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstore_management.Database.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PIN { get; set; }

        public User(string firstName, string lastName, string pin)
        {
            FirstName = firstName;
            LastName = lastName;
            PIN = pin;
        }
    }
}
