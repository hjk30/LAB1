using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person MyPerson1 = new person();
            MyPerson1.NameSurname = ("Василий Пупкин");
            MyPerson1.Gender = (0);
            MyPerson1.Age = (42);
            MyPerson1.Print();
            //person MyPerson3 = new person();
            // MyPerson3.Input();
            //MyPerson3.Print();

            person MyPerson2 = new person("Михаил Андреевич Иванов", 0, 40);

            MyPerson2.Print();
            Organization _1C = new Organization("1C", 1991, MyPerson2);
            _1C.Print();

            Worker worker1 = new Worker("Иван Васильевич Петров", 0, 30);
            worker1.Print();

            HR.Employ(worker1, _1C, 50000, "Программист");
            worker1.Print();
            HR.Dismiss(worker1);
            worker1.Print();
        }
    }
}
