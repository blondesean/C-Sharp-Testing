using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args) //this is for command line arguements you want to pass in ie options
        {
            //example of static method (you can access it without needing to declare the variable, it is inherent to the set of objects in that class
            Console.WriteLine(Math.Sqrt(144));

            UsefulTools.SayHi("butthead");

            Console.ReadLine();
        }
    }
}
