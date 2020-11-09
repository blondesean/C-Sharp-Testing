using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
     class UsefulTools //you can remove the static if you do want to create instances of the object
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
