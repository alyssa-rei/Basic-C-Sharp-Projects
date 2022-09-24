using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints "Car Insurance Application" title.
            Console.WriteLine("Car Insurance Application");
            System.Threading.Thread.Sleep(1500);

            // Prints questions; asks user their age, number of
            // DUIs, and number of speeding tickets they may have.
            // Then converts inputs from string-data-type variables
            // to an integer- and/or Boolean-data-type variables.
            Console.WriteLine("\nWhat is your age?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);
            bool ageOk = (userAge > 15);

            Console.WriteLine("\nHave you ever had a DUI? Please answer \"True\" or \"False\".");
            string dui = Console.ReadLine();
            bool userDui = Convert.ToBoolean(dui);
                
            Console.WriteLine("\nHow many speeding tickets do you have? Please answer with numerals.");
            string tickets = Console.ReadLine();
            int userTickets = Convert.ToInt32(tickets);
            bool tooMany = (userTickets > 3);

            // Prints question; asking if user is qualified, then
            // prints either "yes" or "no," dependent upon user's answers.
            // User qualifies only if Age is above 15, DUI history is False,
            // and number of Speeding Tickets is less than 3.
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nQualified?");
            if (ageOk == true && userDui == false && tooMany == false)
            {
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Yes.");
            }
            else
            {
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("No.");
            }
                         
            Console.ReadLine();
        }
    }
}
