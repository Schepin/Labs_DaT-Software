/* Добавить в массив столбец нулей 0 после каждого столбца с
элементом, большим по модулю среднего арифметического
положительных элементов.*/
using System;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> newArray = new List<List<int>>();
            newArray.Add(new List<int>() {-1, 2, 3 });
            newArray.Add(new List<int>() { 4, -5,6 });
            newArray.Add(new List<int>() { 7, 8, -9 });
            AddingZerosToAnArray array = new AddingZerosToAnArray();



            List<List<int>> result = array.AddingZeros(newArray);
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    //Console.Write(result[i][ j].ToString().PadLeft(3) + " ");
                    Console.Write(string.Format("{0,4} ", result[i][j]));
                }
            }
            Console.ReadLine();
        }
    }
}
