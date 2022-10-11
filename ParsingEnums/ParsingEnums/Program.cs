
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to enter the current day of the week.
            // If the user enters a valid day, it'll be displayed;
            // otherwise, if an errors occurs, a message will be
            // displayed, asking the user to enter the day again.
            try
            {
                Console.WriteLine("Please, enter the current day of the week:");
                string userDay = Console.ReadLine();
                Console.WriteLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
                Console.WriteLine("Today is " + day + ".");
                Console.ReadLine();
            }
            catch (SystemException)
            {
                Console.WriteLine("Please, enter the actual day:");
                Console.ReadLine();
            }
        }
        
        // Creating an enum for the days of the week.
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}