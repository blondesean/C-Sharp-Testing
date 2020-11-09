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
            //declare book like normal variable
            Book harrypotter = new Book("HP 3", "Prisoner of Azkahban", "JK Rowling", 347);
            Book lordOftheRings = new Book(); //you can do this if you have another constructor for this purpose

            Console.WriteLine(harrypotter.title + " has " + harrypotter.pages + " pages.");
            


            Console.ReadLine();
        }
    }
}
