using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    static internal class HR
    {
        static public void Employ(Worker worker, Organization organization, int salary = 0, string post = "")
        {
            worker.Salary = salary;
            worker.Post = post;
            worker.Workplace = organization;
            
        }
        static public void Dismiss(Worker worker)
        {
            worker.Salary = 0;
            worker.Post = "";
            worker.Workplace = null;
        }
    }
}
