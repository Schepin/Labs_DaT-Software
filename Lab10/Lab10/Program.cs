using System;
using System.Collections.Generic;
using System.IO;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            StreamReader Reader = new StreamReader("...\\TheInitialArrayofNumbers.txt");
            List<int> array = new List<int>();
            while ((line = Reader.ReadLine()) != null)
            {
                array.Add(Convert.ToInt32(line));
            }

            AddingZerosToAnArrayOfNumbers newArray = new AddingZerosToAnArrayOfNumbers(array);

            StreamWriter Writer = new StreamWriter("...\\Result.txt");
            foreach (int i in newArray.AnalysisOfTheArrayOfNumbers())
            {
                Writer.Write(i + " ");
            }
            Writer.Close();
        }
    }
}
