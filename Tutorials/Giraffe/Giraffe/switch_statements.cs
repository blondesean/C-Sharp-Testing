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

            Console.Write("What day index do you want? ");
            Console.Write("That is a " + GetDay(Convert.ToInt32(Console.ReadLine())));

            //gg so ez

            Console.ReadLine();

        }

        static string GetDay(int dayNum)
        {
            string dayName;

            //How to use a switch (like an if for one constant input
            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break; //if you don't do this the computer will keep checking other cases, which you may want in some cases
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Not a real day index";
                    break;

            }
            return dayName;
        }

    }
}
