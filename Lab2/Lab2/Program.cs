/*Дана строка, содержащая несколько круглых скобок. Если скобки
расставлены правильно (то есть каждой открывающей соответствует
одна закрывающая), то вывести число 0. В противном случае
вывести или номер позиции, в которой расположена первая
ошибочная закрывающая скобка, или, если закрывающих скобок не
хватает, число –1.*/

using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            TextAnalysis CountingBracketsInText = new TextAnalysis();
            Console.WriteLine("Введите текст");
            string Text = Console.ReadLine();
            int CountedAnswer = CountingBracketsInText.ScoringCount(Text);
           
            Console.WriteLine("Результат: {0} ", CountedAnswer);
            if (CountedAnswer == 0) Console.WriteLine("Скобки расставлены правильно");
            if (CountedAnswer == -1) Console.WriteLine("Не хватает закрывающей скобки");
            if (CountedAnswer > 0) Console.WriteLine("Ответ ({0}) равен номеру позиции, в которой расположена первая ошибочная закрывающая скобка", CountedAnswer);
            Console.ReadLine();

        }
    }
}