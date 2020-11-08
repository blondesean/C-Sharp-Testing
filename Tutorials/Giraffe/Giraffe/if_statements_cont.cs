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

            int[] nums3 = { 231, 3842, 32 };

            int maxOf3 = MultiMax(nums3);
            Console.WriteLine("Your max of 3 numbers is = " + maxOf3);

            Console.ReadLine();
        }

        static int MultiMax(int[] nums)
        {
            if (nums[0] > nums[1] && nums[0] > nums[2])
            {
                return nums[0];
            } else if (nums[1] > nums[0] && nums[1] > nums[2])
            {
                return nums[1];
            } else if (nums[2] > nums[0] && nums[2] > nums[1])
            {
                return nums[2];
            } else
            {
                return 0;
            }
        }


    }
}
