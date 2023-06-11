using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2023
{
    // Creating a class to represent a book in my code.
    public class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string hasRead { get; set; }

        public string BookTitle
        {
            get 
            {
                return $"{Title}";
            }
        }

    }
}
