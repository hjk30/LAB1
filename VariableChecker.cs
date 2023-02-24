using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal static class VariableChecker
    {
        static public bool IsAlphabetString(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch < 'A' && ch > 'Z' && ch < 'a' && ch > 'Z' && ch < 'А' && ch > 'Я' && ch < 'а' && ch > 'я')
                {
                    return false;
                }
            }
            return true;
        }
        static public bool IsPositiveNumber(double num)
        {
            return num >= 0;
        }
        static public bool IsPastYear(int year)
        {
            return year <= DateTime.Now.Year;
        }
        static public void AssertAlphabetString(string str)
        {
            if (!IsAlphabetString(str))
            {
                throw new ArgumentException("String contains NON-alphabet Char`s");
            }
        }
        static public void AssertPositiveNumber(double num)
        {
            if (!IsPositiveNumber(num))
            {
                throw new ArgumentException("Negative number");
            }
        }
        static public void AssertPastYear(int Year)
        {
            AssertPositiveNumber(Year);
            if (!IsPastYear(Year))
            {
                throw new ArgumentException("Year is future");
            }
        }
    }
}