namespace Lab7
{
    class SortingTheArrayOfNumbers
    {
        private int[,] array;
        public SortingTheArrayOfNumbers(int[,] beginArray)
        {
            array = beginArray;
        }

        public int[,] Rearrangement()
        {
           // int theLasttNegativeElement = 0;
            int indexOfNegative = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[array.GetLength(0)-1, j] < 0 )
                    {
                        indexOfNegative = j;
                        break;
                    }
            }

            int theFirstPositiveElement = array[0, 0];
            int indexOfPositive = 0;

            for (int j = array.GetLength(1) - 1; j >= 0; j--)
            {
                if (array[0, j] > 0 )
                    {
                        indexOfPositive = j;
                        break;
                    }
                }
            

            int temp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                temp = array[i, indexOfPositive];
                array[i, indexOfPositive] = array[i, indexOfNegative];
                array[i, indexOfNegative] = temp;
            }
            return array;
        }
    }
}
