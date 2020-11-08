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


            //Call the method
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            Console.Write("What is your age? ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            SayHiToUser(userName, userAge);



            Console.ReadLine();
        }

        //You can define a new method here, void returns nothing
        static void SayHiToUser(string name, int age) //has to recieve one parameter that is type string called name, and int
        {
            Console.WriteLine("Hello " + name + ".\nWhat is it like being " + age + "?" );
        }

    }
}
