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
            Book harrypotter = new Book("HP 3", "Prisoner of Azkahban", "JK Rowling", 199, "PG-13");

            Console.WriteLine("The book " + harrypotter.title + " by " + harrypotter.author + " has " + harrypotter.pages);
            Console.Write("It is rated " + harrypotter.Rating);

            Console.ReadLine();
        }
    }
}
