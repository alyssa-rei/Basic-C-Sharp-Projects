using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the current date + time for user;
            // then asking them to enter a number.
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("\nPlease, enter a number:");

            // The user-entered number is converted from a
            // string to integer-data-type. That number is then
            // added to the current time, in hours, and a message
            // prints for the user, telling them what the future
            // times will be.
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime future = now.AddHours(hours);
            Console.WriteLine("In {0} hours, it'll be {1}.", hours, future);
            Console.Read();
        }
    }
}
