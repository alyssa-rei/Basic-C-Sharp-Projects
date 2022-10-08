using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating "IQuittable" object with the first name of
            // "Sample" and last name of "Student";
            // Calling "Quit()" method on "IQuittable" object.

            IQuittable a = new Employee();
            a.Quit("Sample", "Student");
            Console.ReadLine();
        }
    }
}
