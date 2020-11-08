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

            //declare array with []
            int[] luckyNumbers = { 7, 21, 333, 1000};
            
            //how to declare an empty array of particular size
            string[] friends = new string[10];
            friends[0] = "Jim";
            friends[4] = "James";

            luckyNumbers[2] = 50;
            Console.WriteLine(luckyNumbers[0] + ", " + luckyNumbers[2]);

            Console.WriteLine(friends[0] + ", " + friends[4]);





            Console.ReadLine();
        }
    }
}
