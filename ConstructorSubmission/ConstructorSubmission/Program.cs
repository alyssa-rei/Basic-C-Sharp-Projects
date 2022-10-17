using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a constant variable; it will not change.
            const string dogsName = "Paxton";
            Console.WriteLine("Let's talk about " + dogsName + ".");

            // Asking the user to enter their dog's breed;
            // Implicitly defining a variable;
            Console.WriteLine("\nPlease, enter your dog's breed:");
            var breed = Console.ReadLine();
            Dogs dogs = new Dogs(breed);
            Console.WriteLine("\nYour dog is a(n) " + dogs.Breed + "." +
                "\nThey are considered a " + dogs.Weight + " breed.");
            Console.ReadLine();
        }
    }
}
