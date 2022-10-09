using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    // Creating a class called "Employee", with Id,
    // FirstName, and LastName properties. Overloading
    // the "==" operator to compare two Employee objects
    // by their Id.
    public class Employee
    { 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee a, Employee b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(Employee a, Employee b)
        {
            return !(a.Id != b.Id);
        }
    }
}