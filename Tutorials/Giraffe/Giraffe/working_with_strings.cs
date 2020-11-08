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
            string phrase = "This can split into a \nnewline";

            Console.WriteLine(phrase);

            //This is called a method, you can do this with variables / defined functions of objects
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("yes"));

            //use this to print a specific character
            Console.WriteLine(phrase[2]); //3rd character

            //where is character / string, returns int, string indexing starts at 0
            Console.WriteLine(phrase.IndexOf("can"));

            //my favorite substring
            Console.WriteLine(phrase.Substring(5, 3));

            

            //Ask for user input to make text viewable to user
            Console.ReadLine();
        }
    }
}
