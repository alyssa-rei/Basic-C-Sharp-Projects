using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing a message to the user, to enter an integer;
            // declaring / converting data-types for num1 and num2.
            Console.WriteLine("Enter an integer to be divided by 2.");
            int num1;
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Prints assigned value of "num1" divided by 2,
            // through Class "Methods" > "methodOne",
            // user-entered "num2" divided by 2, and the
            // static fields from "StaticClass".
            Methods method = new Methods();
            method.methodOne(out num1, num2);

            int addedTotal = num1 + num2;
            Console.WriteLine("\n" + num1 + " plus " + num2 + " is " + addedTotal + ".");

            method.methodOne();

            Console.ReadLine();
        }
    }
}
