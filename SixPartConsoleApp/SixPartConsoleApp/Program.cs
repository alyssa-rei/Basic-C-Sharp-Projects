using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// CONSOLE APP ASSIGNMENT
            //
            // PART ONE OF SIX
            // Creating a loop that iterates through each string in the array
            // and adds the user's text input to the end of each string.
            // The second loop prints each string in the array, one at a time.
            string[] countries = { "Argentina + ", "Chile + ", "Indonesia + ", "Kenya + ", "New Zealand + ", "South Africa + ", "Thailand + " };
            Console.WriteLine("Name a country you'd like to visit:");
            string visitCountry = Console.ReadLine();

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = countries[i] + visitCountry;
            }

            for (int j = 0; j < countries.Length; j++)
            {
                Console.WriteLine("Would you like to visit " + countries[j] + "?");
            }
            Console.ReadLine();



            // PART TWO OF SIX
            //
            // Creating an infinite loop.
            //for (int i = 0; i < 5; i--)
            //{
            //    Console.WriteLine("Hello, World");
            //}
            //
            // Fixed infinite loop, but having the number of prints
            // instead increase to no more than five.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello, World");
            }
            Console.ReadLine();



            // PART THREE OF SIX
            //
            // Creating a loop where the "<" operator is used
            // to determine whether to continue iterating the loop.
            string[] colors = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            Console.ReadLine();

            // Creating a loop where the "<=" operator is used
            // to determine where to continue itereating the loop.
            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine(colors[j]);
            }
            Console.ReadLine();



            // PART FOUR OF SIX
            //
            // Creating a list where each item is unique and asking
            // the user to name their favorite shape, to find in the list.
            List<string> shapes = new List<string>();
            shapes.Add("square");
            shapes.Add("rectangle");
            shapes.Add("triangle");
            shapes.Add("trapezoid");
            shapes.Add("circle");
            shapes.Add("oval");
            shapes.Add("octagon");
            shapes.Add("hexagon");
            shapes.Add("pentagon");

            Console.WriteLine("Please enter the name of your favorite shape to find in the list:");
            string userShape = Console.ReadLine();

            // Creating a loop that iterates through the list and then displays
            // the index and name of the shape. If the shape named isn't on the
            // list, a message will display to the user, stating so.
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] == userShape)
                {
                    Console.WriteLine("\nIndex " + i + ": " + userShape);
                    Console.ReadLine();
                    break;
                }

                if (shapes.Contains(userShape) == false)
                {
                    Console.WriteLine("\nYour favorite shape is not on the list.");
                    Console.ReadLine();
                }
            }



            // PART FIVE OF SIX
            //
            // Creating a list of strings, with two of them being identical.
            // A message is then printed, asking the user their favorite color.
            List<string> colorList = new List<string>();
            colorList.Add("blue");
            colorList.Add("white");
            colorList.Add("yellow");
            colorList.Add("black");
            colorList.Add("blue");
            colorList.Add("red");

            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            // Creating a loop that iterates through the list and displays
            // the indices of the item matching the user's entered text.
            for (int i = 0; i < colorList.Count; i++)
            {
                if (colorList[i] == favColor)
                {
                    Console.WriteLine("Index " + i + ": " + favColor);
                    Console.ReadLine();
                }
                if (colorList.Contains(favColor) == false)
                {
                    Console.WriteLine(favColor + " is not on the list.");
                    Console.ReadLine();
                }
            }



            // PART SIX OF SIX
            //
            // Creating a string list that contains two, identical strings.
            List<string> letters = new List<string>() { "A", "B", "C", "C", "D" };
            List<string> duplicate = new List<string>();
            
            // Creating a loop that evaluates each item in the list and
            // displays a message showing the string and whether or not
            // it has already appeared in the list.
            foreach (string letter in letters)
            {
                if (duplicate.Contains(letter))
                {
                    Console.WriteLine(letter + " - this item is a duplicate");
                    System.Threading.Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine(letter + " - this item is unique");
                    System.Threading.Thread.Sleep(500);
                    duplicate.Add(letter);
                }

            }
            Console.ReadLine();

        }
    }
}
