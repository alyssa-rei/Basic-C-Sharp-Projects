using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comparing Employee objects by their Ids
            Employee a = new Employee() { Id = 1, FirstName = "Sample1", LastName = "Student" };
            Employee b = new Employee() { Id = 2, FirstName = "Sample2", LastName = "Student" };

            Console.WriteLine("Employees A + B have the same Id: " + (a.Id == b.Id));
            Console.WriteLine("Employees A + B have the same First Name: " + (a.FirstName == b.FirstName));
            Console.WriteLine("Employees A + B have the same Last Name: " + (a.LastName == b.LastName));

            Console.ReadLine();
        }
    }
}
