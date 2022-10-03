using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class ThreeMethods
    {
        // Creating Method One; taking in the received parameter,
        // adding it by 20, then printing the total.
        public int method(int var)
        {
            int totalOne = var + 20;
            return totalOne;
        }

        // Creating Method Two; taking in the received, decimal parameter,
        // subtracting it by 20, then printing the total.
        public int method(decimal var)
        {
            decimal totalTwoDecimal = var - 20;
            int totalTwo = Convert.ToInt32(totalTwoDecimal);
            return totalTwo;
        }

        // Creating Method Three; taking in the received parameter,
        // multiplying it by 20, if possible, then printing the total.
        public int method(string var)
        {
            try
            {
                int totalThreeString = Convert.ToInt32(var) * 20;
                return totalThreeString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
