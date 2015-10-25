using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please enter your name: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Hello {0}, Welcome to the program \n", name);

            int menuOption;
            do
            {
                Console.WriteLine("Please enter the number to select a choice: \n");
                Console.WriteLine("1) To add two number together");
                Console.WriteLine("2) To find out whether a number is a Prime number");
                
                    menuOption = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                    switch (menuOption)
                    {
                        case 1:
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
                            break;
                        case 2:
                        int number;
                        do
                        {
                            Console.WriteLine("Please enter the number to check if it's a Prime number: ");
                            number = Convert.ToInt32(Console.ReadLine());

                            int a = 0;

                            for (int i = 1; i <= number; i++)
                            {
                                if (number % i == 0)
                                {
                                    a++;
                                }
                            }
                            if (a == 2)
                            {
                                Console.WriteLine("The number {0} you entered is a prime number", number);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("The number {0} you entered is not a prime number", number);
                                Console.ReadLine();
                                Console.Clear();
                            }
                        } while (number != 1);
                         
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                Console.Clear();
                
                
            } while (menuOption != 4);
            

        }
    }
}
