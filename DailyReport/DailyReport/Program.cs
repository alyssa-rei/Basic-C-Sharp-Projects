using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints "The Tech Academy" Title
            Console.WriteLine("The Tech Academy");
            Console.WriteLine(" ");

            // Delays next line by 2 seconds
            System.Threading.Thread.Sleep(2000);

            // Prints "Student Daily Report" and asks user their name
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");

            // Stores user input as string variable "myName",
            // prints user name, and asks what course they're on
            string myName = Console.ReadLine();
            Console.WriteLine("Great, " + myName + "! What course are you on?");

            // Stores user input as string variable "courseName",
            // and asks on what page of the course is the user
            string courseName = Console.ReadLine();
            Console.WriteLine("On what page of " + courseName + "?");

            // Stores user input as string variable "pageNumber",
            // and converts/stores it as integer-data-type variable "coursePage"
            string pageNumber = Console.ReadLine();
            int coursePage = Convert.ToInt32(pageNumber);

            // Asks user if they need assistance and stores input as string "helpStatus",
            // then converts/stores it as Boolean-data-type variable "needHelp".
            // If "true", prints instruction to user, to reach out to instuctor,
            // If "false, prints instruction to user, to reach out if they need assistance
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string helpStatus = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(helpStatus);
                if (needHelp == true)
                {
                    Console.WriteLine("Please, reach out to an instructor for assistance.");
                }
                if (needHelp == false)
                {
                    Console.WriteLine("Great! However, please, reach out if you do!");
                }

            // Delays next line by 1.5 seconds
            System.Threading.Thread.Sleep(1500); 

            // Asks user if they'd like to share any positive experiences during their study time,
            // stores input as string "myExperience", then asks for any additional feedback,
            // and stores input as "myFeedback"
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string myExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string myFeedback = Console.ReadLine();

            // Asks user how many hours they studied today, stores input as "hoursStudied",
            // then converts/stores it as integer-data-type variable "myHours"
            Console.WriteLine("And how many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int myHours = Convert.ToInt32(hoursStudied);

            // Delays next line by 1.5 seconds, then thanks user for filling out Daily Report
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
