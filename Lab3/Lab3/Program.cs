
/*Дано N целых чисел. Требуется выбрать из них три таких числа,
произведение которых максимально.*/

using System;


namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalysisOfTheArrayOfNumbers Array = new AnalysisOfTheArrayOfNumbers();
            Console.Write("Введите количество элементов в массиве: ");
            int elements = int.Parse(Console.ReadLine());
            int[] array = new int[elements];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива: ");
                array[i] = int.Parse(Console.ReadLine());

            }
            int[] FinalArray = Array.AnalyzingNumbers(array);

            Console.WriteLine("\nЧисла при которых получится наибольшее произведение:");
            for (int j = 0; j < FinalArray.Length; j++)
            {
                Console.Write(FinalArray[j] + " ");
            }

            int Composition = FinalArray[0] * FinalArray[1] * FinalArray[2];
            Console.WriteLine("\nПроизведение равно:");

            Console.Write(Composition);
            Console.ReadLine();
        }
    }
}
