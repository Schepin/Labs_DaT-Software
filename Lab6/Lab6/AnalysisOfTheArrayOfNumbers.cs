using System.Collections.Generic;


namespace Lab6
{
    class AnalysisOfTheArrayOfNumbers
    {
        public int[] AnalyzingNumbers(int[] array)

        {
            List<int> result = new List<int>(array);

            int Element = result[result.Count - 1];
 
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] % Element != 0)
                {

                    result.RemoveAt(i);
                    i--;
                }
            }

            return result.ToArray();
        }

    }
}
