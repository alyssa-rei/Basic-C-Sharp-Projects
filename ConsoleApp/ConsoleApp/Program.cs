using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints message to user, that it will count to 10.
            // Integer-data-type variable "i" is given the value of 1;
            // "i" will continue increasing by 1 as long as its value
            // through the next loop is less than 11.
            Console.WriteLine("Let's count to 10!");
            int i = 1;
            while (i < 11)
            {
                Console.Write(i + " ");
                System.Threading.Thread.Sleep(500);
                i++;
            }

            // Prints message to user, that it will count down to 1.
            // Integer-data-type variable "cdi" is given the value of 10;
            // "cdi" will continue decreasing by 1 as long as its value
            // through the next loop is greater than 0.
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\n\nNow, let's count back to 1!");
            System.Threading.Thread.Sleep(1000);
            int cdi = 10;
            do
            {
                Console.Write(cdi + " ");
                System.Threading.Thread.Sleep(500);
                cdi--;
            }
            while (cdi > 0);

            Console.Read();
        }
    }
}
