using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    public class PrimeNumber
    {
        //public static void isPrime()
        public bool isPrime(int input, int number2)
        {
            //throw new NotImplementedException();

            number2 = -5;
           
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
                if (input > 0)
                {
                    return true;
                }
                if (input <= number2)
                {
                    return false;
                }
                return false;
                
        }
    }
}
