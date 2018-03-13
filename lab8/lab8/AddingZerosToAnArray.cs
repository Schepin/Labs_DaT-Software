using System;
using System.Collections.Generic;

namespace lab8
{
    class AddingZerosToAnArray
    {
        private int AverageArithmeticNumber(int sum,int amounts)
        {
            int AverageArithmetic = sum / amounts;
            return AverageArithmetic;
        }
        public List<List<int>> AddingZeros(List<List<int>> array)
        {
            int sum = 0;
            int amount = 0;
            
            List<int> AverageArithmetic = new List<int>();
            for (int j = 0; j < array.Count; j++)
            {
                for (int i = 0; i < array.Count; i++)
                {
                     if(array[i][j]>0)
                     {
                        sum += array[i][j];
                        amount += 1;
                     } 
                }
                AverageArithmetic.Add(AverageArithmeticNumber(sum, amount));
                amount = 0;
                sum = 0;
            }

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    if (Math.Abs(array[i][j]) > AverageArithmetic[i])
                    {
                        array[i].Insert(j + 1, 0);
                    }
                }
            }
            return array;
        }
    }
}
