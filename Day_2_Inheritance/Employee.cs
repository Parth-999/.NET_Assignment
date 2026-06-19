using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Inheritance
{

    public class Employee : Person
    {
        private double Salary;
        private string Dept;

        public Employee(double Salary, string Dept, string Pname, int Pid, int Pmobile) : base(Pname, Pid, Pmobile)
        {
            this.Salary = Salary;
            this.Dept = Dept;
        }

        public override void Show()
        {
            //base.Show();

            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Dept :" + Dept);
        }

    }
}
