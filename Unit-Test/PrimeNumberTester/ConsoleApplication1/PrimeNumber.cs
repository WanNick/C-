using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PrimeNumber
    {
        public bool isPrime(int input, int input2)
        {

            int a = 0;

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }

            if (input <= 0)
                // The IF statement above checks to see whether input is less than or equal to zero.
                // if it's less than or equal to 0 it will return true. 
            {
                return true;
            }
            if (input > 0)
                // The IF statement above checks to see whether input2 is greater than zero.
                // if it is its going to return false.
            {
                return false;
            }

            return false;

            //throw new NotImplementedException();
        }
    }
}
