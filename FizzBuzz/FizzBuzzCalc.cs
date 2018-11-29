using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzCalc
    {
        public static string Get(int n)
        {
            /*
            string result = n.ToString(); ;
            return result;
            */
            if (n % 3 == 0)
            {
                return "Fizz";
            }
            else if (n % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return n.ToString();
            }
        }
    }
}
