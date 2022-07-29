using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugstore_management.Database.Models
{
    public class Druggist : User
    {
        public string Education { get; set; }
        public string Experience { get; set; }

        public Druggist(string firstName, string lastName, string pin, string education, string experience)
            : base(firstName, lastName, pin)
        {
            Education = education;
            Experience = experience;
        }


    }
}
