using System;
using System.Collections.Generic;

namespace Lab5
{
    class AnalysisOfTheArrayOfNumbers
    {
        public int[] InsertZeros(int[] array)

        {
            int amount = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum = sum + array[i];
                    amount += 1;

                }
            }

            int arithmeticMean = sum / amount;
            Console.WriteLine("\nСреднее арифметическое:\n" + arithmeticMean);

            List<int> result = new List<int>(array); // добавляем в конец списка элементы списка newTeams

            for (int i = 0; i < result.Count; i++)
            {
                if ((Math.Abs(result[i]) > arithmeticMean))
                {
                    result.Insert(i + 1, 0);
                }
            }
            
            return result.ToArray();
        }

    }
}
