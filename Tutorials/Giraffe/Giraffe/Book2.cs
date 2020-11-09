using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    //to add a class right click build below solution > add > new > class
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public static string pageType = "paper"; //can define a variable shared across all objects of this class
        public static int bookCount = 0;

        //start of constructor, run when the class is created
        public Book(string name, string aTitle, string aAuthor, int aPages) 
        {
            Console.WriteLine("Writing " + name + " ... lol");
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            bookCount++; //can perform a function for the whole set of classes whenever one is constructed

        }



    }
}
