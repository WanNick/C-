using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    class Add
    {
        public static void addition()
        {
            Console.WriteLine("This selection allows you to find the sum of two numbers \n");
            Console.WriteLine("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int ans = num1 + num2;

            Console.WriteLine("The sum of the {0} and {1} is {2}", num1, num2, ans);
            Console.ReadLine();

        }
    }
}
