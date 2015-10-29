using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    public class Welcome
    {
        public bool welcome1(string input, string input2)
        //public static void welcome1 ()
        {

            input2 = "";
            
            if (input == "Nick")
            {
                return true;
            }
            if (input != input2)
            {
                return true;
            }
            if (input2 != string.Empty)
            {
                return false;
            }
                return false;
            

            //throw new NotImplementedException();

            /*Console.WriteLine("Hello, Please enter your name: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Hello {0}, Welcome to the program \n", name);*/
        }
    }
}
