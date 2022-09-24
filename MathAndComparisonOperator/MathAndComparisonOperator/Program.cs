using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints "Anonymous Income Comparison Program" Title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine(" ");

            // Delays next line by 2 seconds, then asks user
            // to enter Person 1's hourly wage. Delays following
            // line by 1 second, then asks user to enter
            // Person 1's weekly, worked hours.
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Person 1");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What is your hourly rate?");
            string myRate1 = Console.ReadLine();
            double hourlyRate1 = Convert.ToDouble(myRate1);
            Console.WriteLine("\nOkay, and how many hours do you work weekly?");
            string myHours1 = Console.ReadLine();
            int weeklyHours1 = Convert.ToInt32(myHours1);

            // Person 1's hourly wage and weekly hours worked
            // are multiplied. That total is then multiplied by
            // 52 (weeks in a year) to get Person 1's annual salary
            double person1 = (hourlyRate1 * weeklyHours1) * 52;

            // Delays next line by 1 second, then asks user
            // to enter Person 2's hourly wage. Delays following
            // line by 1 second, then asks user to enter
            // Person 2's weekly, worked hours.
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nPerson 2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("What is your hourly rate?");
            string myRate2 = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(myRate2);
            Console.WriteLine("\nOkay, and how many hours do you work weekly?");
            string myHours2 = Console.ReadLine();
            int weeklyHours2 = Convert.ToInt32(myHours2);

            // Person 2's hourly wage and weekly hours worked
            // are multiplied. That total is then multiplied by
            // 52 (weeks in a year) to get Person 2's annual salary
            double person2 = (hourlyRate2 * weeklyHours2) * 52;

            // Delays next line by 2 seconds, prints
            // Person 1's annual salary, followed by another
            // delay. Then, Person 2's annual salary is
            // printed.
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nAnnual salary of Person 1:");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(person1 + "\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Annual salary of Person 2:");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(person2 + "\n");

            // Delays next line by 2 seconds, then prints,
            // asking if Person 1 has a higher, annual salary
            // than Person 2.
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            // Boolean-data-type variable, "trueOrFalse," is
            // given the value of comparing the values of variables
            // "person1" and "person2"; asking if Person 1's salary
            // is greater than (>) Person 2's salary.
            // Then prints if "trueOrFalse" statement is true or false.
            bool trueOrFalse = person1 > person2;
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}
