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
            //using a method to determine length of array we can loop through all elements later
            int[] luckyNumbers = { 1, 2, 3, 5, 7, 9, 13, 17, 19, 23, 29 };

            //for loops can initialize unlike while, next is condition, what is executed every loop
            for (int i = 0; i < luckyNumbers.Length; i++ )
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            //gg so ez

            Console.ReadLine();

        }

    }
}
