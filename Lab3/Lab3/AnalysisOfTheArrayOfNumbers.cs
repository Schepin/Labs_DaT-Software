namespace Lab3
{
    class AnalysisOfTheArrayOfNumbers
    {
        public int[] AnalyzingNumbers(int[] array)
        {
            int Number1 = array[0];
            int Number2 = array[1];
            int Number3 = array[2];
            int negativeMax1 = array[0];
            int negativeMax2 = array[1];

            for (int i = 0; i < array.Length; i++)
            {
                if (Number1 < array[i])
                {
                    Number3 = Number2;
                    Number2 = Number1;
                    Number1 = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (Number1 > array[i])
                {
                    negativeMax2 = negativeMax1;
                    negativeMax1 = array[i];
                }
            }

            int[] answer = new int[3];
            if (Number1 * Number2 * Number3 > Number1 * negativeMax1 * negativeMax2)
            {
                answer[0] = Number1;
                answer[1] = Number2;
                answer[2] = Number3;
            }
            else
            {
                answer[0] = Number1;
                answer[1] = negativeMax1;
                answer[2] = negativeMax2;
            }

            return answer;

        }
    }
}
