using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Creates String Array; values given for indices 0-3.
        // Prints message to user, asking them to select which
        // index they'd like to view. If the index exists, user
        // will see its value; if not, a message will print stating so.
        string[] stringArray = new string[4];
        stringArray[0] = "String 0.";
        stringArray[1] = "String 1.";
        stringArray[2] = "String 2.";
        stringArray[3] = "String 3.";

        Console.WriteLine("Please, select which index you'd like to view from the String Array.");
        string stringIndex = Console.ReadLine();
        int userStringIndex = Convert.ToInt32(stringIndex);
        if (userStringIndex <= 4)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nIndex " + userStringIndex + " = " + stringArray[userStringIndex]);
        }
        else
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nIndex " + $"{userStringIndex} does not exist.");
        }



        // Creates Integer Array; values given for indices 0-3
        // Prints message to user, asking them to select which
        // index they'd like to view. If the index exists, user
        // will see its value; if not, a message will print stating so.
        int[] intArray = new int[4];
        intArray[0] = 10;
        intArray[1] = 100;
        intArray[2] = 1000;
        intArray[3] = 10000;

        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("\nPlease, select which index you'd like to view from the Integer Array.");
        string intIndex = Console.ReadLine();
        int userIntIndex = Convert.ToInt32(intIndex);
        if (userIntIndex <= 4)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nIndex " + userIntIndex + " = " + intArray[userIntIndex]);
        }
        else
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nIndex " + $"{userIntIndex} does not exist.");
        }



        // Creates String List; values given for indices 0-3.
        // Prints message to user, asking them to select which
        // index they'd like to view. If the index exists, user
        // will see its value; if not, a message will print stating so.
        List<string> stringList = new List<string>();
        stringList.Add("List string #0.");
        stringList.Add("List string #1.");
        stringList.Add("List string #2.");
        stringList.Add("List string #3.");

        System.Threading.Thread.Sleep(1000);
        Console.WriteLine("\nPlease, select which index you'd like to view from the String List.");
        string stringListIndex = Console.ReadLine();
        int userStringListIndex = Convert.ToInt32(stringListIndex);

        if (userStringIndex <= 4)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nIndex " + userStringListIndex + " = " + stringList[userStringListIndex]);
        }
        else
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nIndex " + $"{userStringListIndex} does not exist.");
        }

        Console.ReadLine();
    }
}
