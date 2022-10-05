using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Displays a message to the user, asking them to enter
            // a number, then a second number.
            Console.WriteLine("Please, enter your first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter your second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // "methodOne" is called from the "VoidMethod" class.
            // The first number is passed through an equation,
            // while the second number will display as-is,
            // not included in any operations.
            VoidMethod method = new VoidMethod();
            method.methodOne(num1, num2);

            Console.ReadLine();
        }
    }
}
