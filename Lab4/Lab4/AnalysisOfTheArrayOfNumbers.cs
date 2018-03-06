namespace Lab4
{
    class AnalysisOfTheArrayOfNumbers
    {
        public int[] SwapFirstEvenAndLastNegative(int[] array)
        {
            int firstEvenNumber = 1;
            int lastNegativeNumber = 1;
            int temp = 1;
            for (int i = array.Length - 1; i >= 0; i++)
            {
                if (array[i] < 0)
                {
                    lastNegativeNumber = i;
                    break;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) == 0)
                {
                    firstEvenNumber = i;
                    break;
                }
            }

            temp = array[firstEvenNumber];
            array[firstEvenNumber] = array[lastNegativeNumber];
            array[lastNegativeNumber] = temp;

            return array;
        }
    }
}
