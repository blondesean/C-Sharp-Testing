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

            //NOTICE THAT I USED WRITE NOT WRITELINE, write does not go to the next line after like \n
            Console.Write("Please give me your name. ");
            
            //give it place to store
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);



            Console.ReadLine();
        }
    }
}
