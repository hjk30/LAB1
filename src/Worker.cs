using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Worker: person
    {
        private int _salary;
        private string _post;
        private Organization _workplace; //Класс имеет ссылочный тип, поэтому можно без указателя

        public string Post
        {
            get { return _post; }
            set { _post = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set {
                VariableChecker.AssertPositiveNumber(value);
                _salary = value;
            }
        }

        internal Organization Workplace
        {
            get { return _workplace; }
            set { _workplace = value; }
        }

        public Worker(string name_surname = "DefaultName", int gender = 0, int age = 0, int salary = 0, string post = "DefaultPost", Organization workplace = null) : base(name_surname, gender, age)
        {
            Salary = salary;
            Post = post;
            Workplace = workplace;
        }
        public override void Print()
        {
            string gender = "муж.";
            if (Gender == 1) gender = "жен.";
            string workText = " ";
            if (Post == "DefaultPost")
            {
                workText += "Безработный";
            }
            else
            {
                workText += "Место работы " + Workplace.Name + " пост: " + Post;
            }
            Console.WriteLine(NameSurname + " возраст " + Age + " пол " + gender + workText);
        }
    }
}
