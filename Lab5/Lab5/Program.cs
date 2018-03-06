/*Вставить 0 после каждого элемента, большего по модулю среднего
арифметического положительных элементов. Тестовый массив 4 5 6
-4 -5 -12 -34 3 4 Результат: среднее арифметическое равно 4,4,
результат вывода: 4 5 0 6 0 -4 -5 0 -12 0 -34 0 3 4*/

using System;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalysisOfTheArrayOfNumbers Array = new AnalysisOfTheArrayOfNumbers();
            Console.Write("Введите количество элементов в массиве: ");
            int Number;
            do
            {

                Console.Write("Размер массива (N) = "); // N должна быть не менее двух
            }

            while ((Number = Convert.ToInt32(Console.ReadLine())) < 2);
            // Заполняем массив случайными числами
            Random rnd = new Random();
            Console.Write("Первоначальный массив чисел:\n");

            int[] arr = new int[Number];
            for (int i = 0; i < Number; i++)

            {
                arr[i] = rnd.Next(-100, 100);
                // Сразу же выводим массив
                Console.Write(arr[i].ToString() + ' ');
            }

            int[] FinalArray = Array.InsertZeros(arr);

            Console.WriteLine("\nПеределанный массив чисел:");

            for (int i = 0; i < FinalArray.Length; i++)
            {
                Console.Write(FinalArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
