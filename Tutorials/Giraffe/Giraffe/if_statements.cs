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


            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall) //you can also use or ||
            {
                Console.WriteLine("You are a tall male.");
            } else if (!isMale)
            {
                Console.WriteLine("You are not a male.");
            }
            else
            {
                Console.WriteLine("You are not tall");
            }


            Console.ReadLine();
        }



    }
}
