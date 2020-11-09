using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class SouffleChef : Chef //now the souffle chef inheirits / can do everything the Chef can do
    {
        public void MakeSouffle() //this is unique to the souffle chef
        {
            Console.WriteLine("The chef makes souffle");
        }

        public override void MakeSpecialDish() //in inheritence the keyword override replaces the super class definition (specified as virtual)
        {
            Console.WriteLine("The chef makes creme fraiche");
        }

    }
}
