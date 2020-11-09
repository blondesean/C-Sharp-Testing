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

            try //will attempt to this, if it fails then it will go to catch
            {
                Console.Write("Please enter the first number to add. ");
                string num1 = Console.ReadLine();
                Console.Write("Please enter the second number to add. ");
                string num2 = Console.ReadLine();
                Console.WriteLine("Your result: " + num1 + " + " + num2 + " = " + (Convert.ToInt32(num1) / Convert.ToInt32(num2))); //this gives infinity when number format = double
            }
            /*
            catch(Exception e) //come to here on error
            {
                Console.Write("That don't make no sense. Try to not " + e.Message);
            }
            */
            catch(DivideByZeroException e)
            {
                Console.Write("That's dividing by zero bro. ");
            }
            catch(FormatException e)
            {
                Console.Write("Bruh did you put a letter in? ");
            }
            finally //runs after any catch if wanted
            {
                Console.Write("Try again.");
            }



            Console.ReadLine();
        }
    }
}
