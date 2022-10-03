using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing a message to the user; telling them to enter a number
            // to be included in three, different math operations - 1 addition,
            // 1 subtraction, and 1 multiplication operation.
            Console.WriteLine("Please, enter an integer to be added by 20.");
            int userInteger = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease, enter a decimal (##.##) to be subracted by 20.\n" +
                "Answer will be rounded to the closest integer.");
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPlease, enter an integer to be multiplied by 20.");
            string userString = Convert.ToString(Console.ReadLine());


            ThreeMethods method = new ThreeMethods();

            // Calling the first method and printing the math operation.
            int totalOne = method.method(userInteger);
            Console.WriteLine("\n" + userInteger + " + " + 20 + " = " + totalOne);
            // Calling the second method and printing the math operation.
            int totalTwo = (int)method.method(userDecimal);
            Console.WriteLine("\n" + userDecimal + " - " + 20 + " = " + totalTwo);
            // Calling the third method and printing the math operation.
            string totalThree = method.method(userString);
            Console.WriteLine("\n" + userString + " * " + 20 + " = " + totalThree);

            Console.ReadLine();
        }
    }
}
