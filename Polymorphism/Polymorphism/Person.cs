using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Creating a "Person" class and giving it two properties -
    // both, string-data-types and called "FirstName" and
    // "LastName".
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Printing "FirstName" and "LastName".
        public void SayName()
        {
            Console.Write("Name: " + FirstName + " " + LastName);
        }
    }
}
