using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Method
{
    class TwoIntegers
    {
        public double method(double var1, [Optional] double var2)
        {
            double totalAmount = var1 + var2 + 10;
            return totalAmount;
        }
    }
}
