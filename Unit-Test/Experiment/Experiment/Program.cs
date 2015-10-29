using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

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
                        //Add.addition();
                            break;
                        case 2:
                        //PrimeNumber.isPrime();
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
