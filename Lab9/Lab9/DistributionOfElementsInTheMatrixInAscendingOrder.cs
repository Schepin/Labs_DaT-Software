using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class DistributionOfElementsInTheMatrixInAscendingOrder
    {
        private int[,] array;
        public DistributionOfElementsInTheMatrixInAscendingOrder(int[,] beginArray)
        {
            array = beginArray;
        }

        public int[,] Rearrangement()
        {
            int temp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int x = 0; x < array.GetLength(0); x++)
                    {
                        for (int y = 0; y < array.GetLength(1); y++)
                        {
                            if (array[i, j] > array[x, y])
                            {
                                temp = array[i, j];
                                array[i, j] = array[x, y];
                                array[x, y] = temp;
                            }
                        }
                    }
                }
            }

            return array;
        }
    }
}
