using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating and initializing an "Employee" object
            // with the first name of "Sample" and last name of "Student";
            // Calling "SayName()" method o "Employee" object.
            Employee a = new Employee() { FirstName = "Sample", LastName = "Student"};
            a.SayName();
            Console.ReadLine();
        }
    }
}
