using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class person
    {
        private string _name_surname;
        private int _gender;
        private int _age;
        public string NameSurname
        {
            get { return _name_surname; }
            set {
                VariableChecker.AssertAlphabetString(value);
                _name_surname = value;
            }
        }
        public int Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int Age
        {
            get { return _age; }
            set {
                VariableChecker.AssertPositiveNumber(value);
                _age = value;
            }
        }

        public virtual void Print()
        {
            string gender = "муж.";
            if (Gender == 1) gender = "жен.";
            Console.WriteLine(NameSurname + " возраст " + Age + " пол " + gender);
        }
        public void Input()
        {
            Console.WriteLine("Введите ФИО");
            NameSurname = (Console.ReadLine());
            Console.WriteLine("Введите пол (м - 0, ж - 1)");
            Gender = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите возраст");
            Age = int.Parse(Console.ReadLine());
        }
        public person(string name_surname = "DefaultName", int gender = 0, int age = 0)
        {
            NameSurname = name_surname;
            Gender = gender;
            Age = age;
        }
        ~person()
        {
            //empty destructor
        }
        private void AssertAge(int age)
        {
            if (age < 0) throw new ArgumentOutOfRangeException("Negative Age");
        }
    }
}
