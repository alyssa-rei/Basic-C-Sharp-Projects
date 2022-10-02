using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing a message to the user; telling them to enter a number
            // to be included in three, different math operations - 1 addition,
            // 1 subtraction, and 1 multiplication operation.
            Console.WriteLine("Please, select a number to include in the following math operations. \n" +
                "It will be added, subtracted, and multiplied by 20.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            ThreeMethods method = new ThreeMethods();
            
            // Calling Method One and printing the math operation.
            int totalOne = method.methodOne(userNumber);
            Console.WriteLine("\n" + userNumber + " + " + 20 + " = " + totalOne);
            // Calling Method Two and printing the math operation.
            int totalTwo = method.methodTwo(userNumber);
            Console.WriteLine("\n" + userNumber + " - " + 20 + " = " + totalTwo);
            // Calling Method Three and printing the math operation.
            int totalThree = method.methodThree(userNumber);
            Console.WriteLine("\n" + userNumber + " * " + 20 + " = " + totalThree);

            Console.ReadLine();
        }
    }
}
