using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What number do you want as the base? ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("What number do you want the power to be? ");
            int powNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(PowFunction(baseNum, powNum));

            //gg so ez

            Console.ReadLine();

        }

        static int PowFunction(int baseVal, int exp)
        {
            int result = 1; 

            for (int i = 0; i < exp; i++)
            {
                result = result * baseVal;
            }

            return result;
        }

    }
}
