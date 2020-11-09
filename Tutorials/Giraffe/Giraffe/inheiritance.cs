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

            Chef bill = new Chef();
            bill.MakeChicken();
            //bill.MakeSouffle(); //bill cant do this because only souffle chefs can
            bill.MakeSpecialDish();

            SouffleChef gordon = new SouffleChef();
            gordon.MakeChicken();
            gordon.MakeSouffle();
            gordon.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
