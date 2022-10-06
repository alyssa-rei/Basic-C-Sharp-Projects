using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Methods
    {
        // Creating void, "methodOne" method, with three parameters;
        // outputs "num1", assigned integer, then divides it by 2,
        // outputs total of user-entered integer ("num2") divided by 2.
        public void methodOne(out int num1, int num2)
        {
            num1 = 50;
            int totalOne = num1 / 2;
            int totalTwo = num2 / 2;
            Console.WriteLine("\n" + num1 + " divided by 2 is " + totalOne + ".");
            Console.WriteLine("\nYour number, {0}, divided by 2 is " + totalTwo + ".", num2);
            return;
        }

        // Method overloading by changing the number of parameters;
        // outputs static fields from "StaticClass".
        public int methodOne()
        {
            int staticTotal = StaticClass.num1 * StaticClass.num2;
            Console.WriteLine("\n" + StaticClass.num1 + " multiplied by " + StaticClass.num2 + " is " + staticTotal + ".");
            return staticTotal;
        }
    }
}
