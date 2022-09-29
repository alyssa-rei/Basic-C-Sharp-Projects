using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of integers.
            Console.WriteLine("Numbers List:");
            List<int> numbersList = new List<int>() { 10, 20, 30, 40, 50 };

            // Asking the user to enter a number and printing a message
            // stating that it'll be used as a divisor for each of the the
            // numbers is in the list.
            // Creating a loop that will take each number from the list and
            // divide it by the number the user entered.
            foreach (int number in numbersList)
            {
                Console.WriteLine(number);
            }
            try
            {
                Console.WriteLine("\nPlease, type a number:");
                Console.WriteLine("\nEach number in the list will now be divided by the number you entered.\n");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                foreach (int number in numbersList)
                {
                    int result = number / userNumber;
                    Console.WriteLine(result);
                }
            }
            // If the user enters a non-whole number, this error message is displayed.
            catch (FormatException ex)
            {
                Console.WriteLine("\nPlease, enter a whole number.\n" + ex.Message);
            }
            // If the user enters zero, this error message is displayed.
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nYou cannot use zero.\n" + ex.Message);
            }
            // This error message is displayed for all other exceptions.
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
