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
            //put comma to tell computer there are 2 dimensions
            int[,] numberGrid = { { 1, 2 }, { 4, 5 }, { 7, 8 } };

            //when you don't know the size that it will be, also showing 3d array or Nd array
            int[,,] unknownGrid = new int[3, 2, 2];


            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    unknownGrid[i, j, 0] = numberGrid[i, j] * numberGrid[i, j];
                    Console.Write(unknownGrid[i, j, 0] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();

        }


    }
}
