using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints Package Express greet and instructions
            Console.WriteLine("Welcome to Package Express. \nPlease follow the instructions below.");

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nEnter all answers in the following format: ##.##");

            // Prints question - asking user for the weight of the package,
            // If package weight is above 50.00, will notify user that its
            // unable to be shipped via Package Express. If below 50.00,
            // will print next questions - asking user for dimensions of the package.
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nWhat is the weight of the package?");
            string weight = Console.ReadLine();
            double pkgWeight = Convert.ToDouble(weight);
            if (pkgWeight > 50.00)
            {
                Console.WriteLine("\nPackage is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Prints questions - asking user the height, width, and length
                // of the package. Package's height, width, and length are
                // then added and become the value of "dimensions".
                Console.WriteLine("\nWhat is its height?");
                string height = Console.ReadLine();
                double pkgHeight = Convert.ToDouble(height);

                Console.WriteLine("\nWhat is its width?");
                string width = Console.ReadLine();
                double pkgWidth = Convert.ToDouble(width);

                Console.WriteLine("\nAnd what is its length?");
                string length = Console.ReadLine();
                double pkgLength = Convert.ToDouble(length);

                double dimensions = pkgHeight + pkgWidth + pkgLength;

                // If the dimensions are beyond 50.00, the user will be notified that
                // it is unable to be shipped via Packge Express. If not, a message
                // is printed, letting the user know the quote is being calculated.
                if (dimensions > 50.00)
                {
                    Console.WriteLine("\nPackage is too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    Console.WriteLine("\nGreat! Let's calculate your quote!");
                    // The total of the package's dimensions is then multiplied by
                    // the its weight, then divided by 100 to caculate the cost of
                    // shipping. The cost is printed for the user.
                    System.Threading.Thread.Sleep(2000);
                    double total = (pkgHeight * pkgWidth * pkgLength) * pkgWeight / 100;
                    total = Math.Round(total, 2);
                    Console.WriteLine("\nYour estimated total for shipping this package is: $" + total + "\nThank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
