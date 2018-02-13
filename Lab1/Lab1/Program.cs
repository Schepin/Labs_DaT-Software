/*Дан номер некоторого года (положительное целое число). Вывести
соответствующий ему номер столетия, учитывая, что, к примеру,
началом 20 столетия был 1901 год.*/
using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            CenturyConverter TranslationFromYearToCentury = new CenturyConverter();
            Console.WriteLine("Введите год");
            string Century = Console.ReadLine();
            string cent = TranslationFromYearToCentury.ConvertYear(Century);
            Console.WriteLine("Результат: {0} век", cent);
            Console.ReadLine();
        }
    }
}
