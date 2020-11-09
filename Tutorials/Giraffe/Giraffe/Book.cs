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
        private string rating; //public means can be accessed/changed by anyone, private means only the code in the class can access that

        //start of constructor, run when the class is created
        public Book(string name, string aTitle, string aAuthor, int aPages, string aRating) //you can pass parameters here from when the class is declared
        {
            Console.WriteLine("Writing " + name + " ... lol");
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Rating = aRating; //aRating comes in, then the value given is tied to the property method

        }

        //second constructor, will be called when params are empty 
        public Book()
        {

        }

        //This is a method
        public bool isLong()
        {
            if (pages > 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Getter and setter, type of method called property
        public string Rating //called when Rating is set since it is called in constructor
        {
            get { return rating; } //stored in the declared variable at the 
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value; //this is what the getter is linking to, set the value and pass back
                }
                else
                {
                    rating = "No Rating"; //or if fails check pass this instead
                }
            }
        }

    }
}
