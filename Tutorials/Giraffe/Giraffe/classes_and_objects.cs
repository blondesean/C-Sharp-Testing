﻿using System;
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
            Book harrypotter = new Book();

            harrypotter.title = "Prisoner of Azkahban";
            harrypotter.author = "JK Rowling";
            harrypotter.pages = 347;

            Console.WriteLine(harrypotter.title + " has " + harrypotter.pages + " pages.");
            


            Console.ReadLine();
        }
    }
}
