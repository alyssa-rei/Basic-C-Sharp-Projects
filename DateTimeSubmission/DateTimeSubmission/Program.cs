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
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("\nPlease, enter a number:");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime future = now.AddHours(hours);
            Console.WriteLine("In {0} hours, it'll be {1}.", hours, future);
            Console.Read();
        }
    }
}
