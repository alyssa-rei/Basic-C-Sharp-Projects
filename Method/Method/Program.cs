using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints a message to the user; asking them to enter
            // an integer, then a second, optional integer.
            Console.WriteLine("Please, enter an integer:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter a second integer (optional):");
            string y = Console.ReadLine();

            Console.WriteLine("\nLets see the total of your integer(s), plus ten.");
            System.Threading.Thread.Sleep(1000);

            TwoIntegers method = new TwoIntegers();

            // If the user decides NOT to enter a second integer,
            // a message will print, stating so. Method One will be
            // called and the integer the user entered will then be
            // added with 10 and the equation will be displayed.
            if (y == "")
            {
                double xAmount = x + 10;
                double amount2 = method.methodOne(xAmount);
                Console.WriteLine("\nYou didn't enter a second integer, so...\n" +
                    x + " + " + 10 + " = " + amount2);
            }
            // If the user decides to provide a second integer,
            // Method Two will be called and it will be added with
            // the first integer and 10. The equation is then displayed.
            else if (y != null)
            {
                double yAmount = Double.Parse(y);
                double amount = method.methodTwo(x, yAmount);
                Console.WriteLine("\n" + x + " + " + yAmount + " + " + 10 + " = " + amount); 
            }

            Console.ReadLine();
        }
    }
}
