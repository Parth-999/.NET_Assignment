namespace Day_3_Demo7
{
    internal class Demo_7
    {
        static void Main(string[] args)
        {
            #region Implicit Way
            //Math m1 = new Math();
            //m1.multi(10, 2);
            //m1.add(10, 2);
            //m1.subtract(10, 2);

            //Math2 m2 = new Math2();
            //m2.multi(5,2);
            //m2.add(10, 2);
            //m2.subtract(10, 2);

            //IA aObj = new Math();
            //aObj.add(1, 2);
            //aObj.subtract(2, 1);

            //IB a2Obj = new Math2();
            //a2Obj.add(1, 2);
            //a2Obj.multi(1, 2); 
            #endregion

            #region ExplicitWay
            //IA aobj = new Math2();
            //aobj.add(50, 10);
            //aobj.subtract(50, 10);

            //IB bobj = new Math2();
            //bobj.add(50, 10);
            //bobj.multi(50, 10) 
            #endregion;

            Person p = new Person();

            p.Greet("Pranav");
            //p.Log("Thanks");

            IData id = new Person();
            id.Greet("Atharva");
            id.Log("Shejal");



        }
    }

    public interface IA
    {
        void add(int x, int y);
        void subtract(int x, int y);
    }

    public interface IB
    {
        void add(int x, int y);
        void multi(int x, int y);
    }

    public interface IData
    {
        void Greet(string name);
        void Log(string msg);
    }
    public class Math : IA, IB
    {
        public void add(int x, int y)
        {
            Console.WriteLine($"Add : {x + y}");
        }

        public void subtract(int x, int y)
        {
            Console.WriteLine($"Sub : {x - y}");
        }
        public void multi(int x, int y)
        {
            Console.WriteLine($"Multi : {x * y}");
        }
    }

    public class Math2 : IB, IA
    {
         void IB.add(int x, int y)
        {
            Console.WriteLine($"Add: {x + y + 100}");
        }

         void IB.multi(int x, int y)
        {
            Console.WriteLine($"Multi : {x * y}");
        }
         void IA.subtract(int x, int y)
        {
            Console.WriteLine($"Sub : {(x - y) + 10}");
        }

        void IA.add(int x, int y)
        {
            Console.WriteLine($"Add : {x + y}");
        }
    }

    public class Person : IData
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello {name}");
            IData data = new Person();
            data.Log("damnn");
            //Log("Welcome");
        }

         void IData.Log(string msg)
        {
            Console.WriteLine($"Log : {msg} at {DateTime.Now.ToString()}");
        }
    }
}

