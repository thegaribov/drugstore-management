using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstore_management.Database.Models
{
    public class Owner : User
    {
        public Owner(string firstName, string lastName, string pin)
            :base(firstName, lastName, pin)
        {


        }

    }
}
