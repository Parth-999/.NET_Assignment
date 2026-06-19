using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Inheritance
{
    public class Person
    {
        public string Pname;
        public int Pid;
        private int Pmobile;

        public Person(string Pname, int Pid, int Pmobile)
        {
            this.Pname = Pname;
            this.Pid = Pid;
            this.Pmobile = Pmobile;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name :" + Pname);
            Console.WriteLine("Id :" + Pid);
            Console.WriteLine("Mobile :" + Pmobile);
        }
    }
}
