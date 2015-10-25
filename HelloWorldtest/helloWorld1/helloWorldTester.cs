using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld1
{
    public class helloWorldTester
    {
        public bool helloWorld(string input, string input1)
        {
            input1 = "";
            
            if (input == "Hello World")
            {
                return true;
            }
            if (input != input1)
            {
                return false;
            }
            if (input == string.Empty)
            {
                return true;
            }
            if (input1 == string.Empty)
            {
                return true;
            }

            if (input.Contains("H"))
            {
                return true;
            }
            return false;

            //throw new NotImplementedException();
        }
    }
}
