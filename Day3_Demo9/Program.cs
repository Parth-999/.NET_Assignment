namespace Day3_Demo9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDemo obj = new Myclass();
            obj.Foo();
            //obj.Log();


            Myclass mc = new Myclass();
            //mc.Log();
        }
    }

    public interface IDemo
    {
        public static int id;
        void Foo();
         protected void Log()
        {
            Console.WriteLine("Log method from IDEMO interface");
        }
    }

    public class Myclass : IDemo
    {
        public void Foo()
        {
            Console.WriteLine("Foo method from MyClass");
        }

        public void Log()
        {
            Console.WriteLine("Log method from MyClass");
        }
    }
}
