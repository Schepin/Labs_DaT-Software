using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] beginArray = new int[,] { { 8, 2, -7 }, { -6, 1, 6 }, {4, 9, -4 } };
            DistributionOfElementsInTheMatrixInAscendingOrder Array = new DistributionOfElementsInTheMatrixInAscendingOrder(beginArray);
            int[,] result = Array.Rearrangement();
            for (int i = 0; i < result.GetLength(1); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                    Console.Write(result[i, j].ToString().PadLeft(3) + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
