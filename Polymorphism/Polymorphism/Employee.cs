using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Creating an "Employee" class and having it inherit
    // from the "Person" and IQuittable classes; giving it
    // a property - an integer-data-type called "Id" and
    // implementing the "Quit()" method to print FirstName
    // and LastName parameters.
    class Employee : Person, IQuittable
    {
        static public int Id;

        public void Quit(string FirstName, string LastName)
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
