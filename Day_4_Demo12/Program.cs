namespace Day_4_Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.WrapperMethod();

            Hr hr = new Hr();
            hr.Display();
            hr.EmpData();
           // hr.Name = "dd";
            
            Person p = new Employee();
           // p.Name="jklj";
            p.Display();


            Person p2 = new Person();
            p2.Display();
          
        }
    }

    public class Person
    {
        public virtual string Name{ get; set; } //useless in this code
        public virtual void Display()
        {
            Console.WriteLine("Person : Display");
        }
    }

    public class Employee : Person
    {
        public sealed override string Name { get => base.Name; set => base.Name = value; } //useless in this code
        public override void Display()
        {
            Console.WriteLine("Employee : Display");
        }
    }

    public class Hr : Employee
    {
        public void EmpData()
        {
            Console.WriteLine("Empdata : HR");
        }

        //public override void Display()
        //{
        //    base.Display();
        //}
    }

    public class Demo
    {
        public void WrapperMethod()
        {
            Hr obj = new Hr();
            obj.EmpData();
        }
    }
}
