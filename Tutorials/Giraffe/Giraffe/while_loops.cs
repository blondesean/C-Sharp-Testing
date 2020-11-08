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
            int index = 1;
            int index2;
            
            //nested whileloop
            while (index <= 5)
            {
                index2 = 1;
                while (index2 <= index)
                {
                    Console.Write("#");
                    index2++;
                }
                Console.WriteLine();
               index++;
            }

            //do loop executes once at least, as shown here
            Console.WriteLine("Start of Do Loop");
            do
            {
                Console.WriteLine(index);
            } while (index <= 5);


            //gg so ez

            Console.ReadLine();

        }

    }
}
