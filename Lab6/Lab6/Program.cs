/*Удалить элементы массива НЕ кратные его последнему
элементу(последний элемент при этом не рассматривать). Тестовый
пример 4 3 4 5 -1 -2 -3 2. Результат: 4 4 -2 2.*/
using System;

namespace Lab6
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
                arr[i] = rnd.Next(-10, 20);
                // Сразу же выводим массив
                Console.Write(arr[i].ToString() + ' ');
            }

            int[] FinalArray = Array.AnalyzingNumbers(arr);


            Console.WriteLine("\nПеределанный массив чисел:\n");

            for (int i = 0; i < FinalArray.Length; i++)
            {
                Console.Write(FinalArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
