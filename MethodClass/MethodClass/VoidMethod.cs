using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    public class VoidMethod
    {
        public void methodOne(double var1, double var2)
        {
            double opTotal = var1 + 30;
            Console.WriteLine("\nYour number, {0}, plus 30 equals " + opTotal + ".", var1);
            Console.WriteLine("\nYour second number, {0}, was not included in the equation.", var2);
            return;
        }
    }
}
