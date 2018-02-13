using System;

namespace Lab1
{
    class CenturyConverter
    {
        public string ConvertYear(string st)
        {

            int year = Convert.ToInt32(st);

            year = (year - 1) / 100;
            year = year + 1;

            string century = year.ToString();
            return century;
        }
    }
}
