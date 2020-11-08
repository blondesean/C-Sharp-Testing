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
            string characterName = "Sean";
            int characterAge = 29;

            //Write to console
            Console.WriteLine("Hello World, my name is " + characterName);
            Console.WriteLine("I am " + characterAge + " years old");

            //can change variable stored value
            characterName = "Tom";
            Console.WriteLine("And I am " + characterName);

            //Ask for user input to make text viewable to user
            Console.ReadLine();
        }
    }
}
