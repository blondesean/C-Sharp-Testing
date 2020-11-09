using System;

namespace Giraffe
{
    class Chef
    {

        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
    
        public void MakeBeef()
        {
            Console.WriteLine("The chef makes beef");
        }

        public void MakeLamb()
        {
            Console.WriteLine("The chef makes lamb");
        }

        public virtual void MakeSpecialDish() //in inheritence the keyword virtual means that this function can be overwritten in the subclass tho it lives in super class
        {
            Console.WriteLine("The chef makes apple pie");
        }



    }
}
