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

            Console.Write("Please enter the first number to add. ");
            string num1 = Console.ReadLine();
            Console.Write("Please enter the second number to add. ");
            string num2 = Console.ReadLine();
            Console.WriteLine("Your result: " + num1 + " + " + num2 + " = " + (Convert.ToDouble(num1) + Convert.ToDouble(num2)));





            Console.ReadLine();
        }
    }
}
