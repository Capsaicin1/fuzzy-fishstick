using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_2023
{
    // Creating a new class to represent a user in my code.
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Fullname
        {
            get
            {
                return $"{ FirstName }{ LastName }";
            }
        }
    }
}
