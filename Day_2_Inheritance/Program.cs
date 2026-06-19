using System.Drawing;
using System.Security.Cryptography;

namespace Day_2_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name:");
            string nm = Console.ReadLine();

            Console.WriteLine("Enter ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mobile:");
            int mob = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Salary:");
            double sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Dept:");
            string dept = Console.ReadLine();

            //Person p = new Person(nm, id, mob);
            Person emp = new Employee(sal,dept,nm,id,mob);

            //p.Show();
            emp.Show();
        }
    }


    

}
