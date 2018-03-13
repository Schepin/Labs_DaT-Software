/*Поменять местами столбец с первым отрицательным в последней
строке и последним положительным в первой.*/
using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] beginArray = new int[,] { { 3, 8, 7 }, { -6, 1, 1 }, {-2, -6, 4 } };
            SortingTheArrayOfNumbers Array = new SortingTheArrayOfNumbers(beginArray);
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
