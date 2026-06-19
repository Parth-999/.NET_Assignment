namespace Day_2_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Database choice: 1. MySql, 2. Oracle, 3. SqlServer");
            int dbChoice = Convert.ToInt32(Console.ReadLine());

            CreateObj cobj = new CreateObj();


            IDatabase a = cobj.CreateMySqlServer(dbChoice);

            if (a != null)
            {
                Console.WriteLine("Enter your db opeartion choice: 1. Insert, 2. Update, 3. Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());
                switch (opChoice)
                {
                    case 1:
                        a.Insert();
                        break;

                    case 2:
                        a.Update();
                        break;
                    case 3:
                        a.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid db operation choice");
                        break;
                }
            }
        }
    }

    
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();

    }
    public class MySqlServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Insert operation done for MySql Db");
        }

        public void Update()
        {
            Console.WriteLine("Update operation done for MySql Db");
        }

        public void Delete()
        {
            Console.WriteLine("Delete operation done for MySql Db");
        }
    }

    public class OracleServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Insert operation done for Oracle Db");
        }
        public void Update()
        {
            Console.WriteLine("Update operation done for Oracle Db");
        }
        public void Delete()
        {
            Console.WriteLine("Delete operation done for Oracle Db");
        }
    }

    public class CreateObj
    {
        public IDatabase CreateMySqlServer(int dbchoice)
        {
            switch (dbchoice)
            {
                case 1:
                    return new MySqlServer();

                case 2:
                    return new OracleServer();

                default:
                    return null;
            }
        }
    }
}
