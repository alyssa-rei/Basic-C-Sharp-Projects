using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class ThreeMethods
    {
        // Creating Method One; taking in the received parameter,
        // adding it by 20, then printing the total.
        public int methodOne(int var)
        {
            int totalOne = var + 20;
            return totalOne;
        }

        // Creating Method Two; taking in the received parameter,
        // subtracting it by 20, then printing the total.
        public int methodTwo(int var)
        {
            int totalTwo = var - 20;
            return totalTwo;
        }

        // Creating Method Three; taking in the received parameter,
        // multiplying it by 20, then printing the total.
        public int methodThree(int var)
        {
            int totalThree = var * 20;
            return totalThree;
        }
    }
}
