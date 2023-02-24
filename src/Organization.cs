using LAB1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Organization
    {
        private string _name;
        private int _year;
        private person _director;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Year
        {
            get { return _year; }
            set {
                VariableChecker.AssertPastYear(value);
                _year = value;
            }
        }
        public person Director
        {
            get { return _director; }
            set { _director = value; }
        }
        public Organization(string name, int year, person director)
        {
            Name = name;
            Year = year;
            Director = director;
        }
        public void Print()
        {
            Console.WriteLine("Организация " + Name + " основана в " + Year + " году, директор - " + Director);
        }
    }
}