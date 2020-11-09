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
            Book harrypotter = new Book("HP 3", "Prisoner of Azkahban", "JK Rowling", 199);
            Console.WriteLine(harrypotter.title + " is the # " + Book.bookCount + " book ");
            Book eragon = new Book("Eragon 1", "The beginning", "Chris Penn", 688); 
            Console.WriteLine(eragon.title + " is the # " + Book.bookCount + " book ");

            Console.WriteLine("Both books are " + Book.pageType);

            Console.ReadLine();
        }
    }
}
