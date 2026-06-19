namespace Day_3_Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
            Console.WriteLine("Enter Your Database Choice: 1.MySql , 2.Oracle , 3.Sql ");
            int dbchoice = Convert.ToInt32(Console.ReadLine());

            DatabaseFactory dbfactory = new DatabaseFactory();
            Database dobj = dbfactory.GetSomeDataBase(dbchoice);

            if (dobj != null)
            {
                Console.WriteLine("Enter Your Choice: 1.Insert , 2.Update , 3.Delete");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        dobj.Insert();
                        break;
                    case 2:
                        dobj.Update();
                        break;
                    case 3:
                        dobj.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            Console.WriteLine("Do you Want to Continue ?");
            string yn = Console.ReadLine().ToLower();

            if (yn == "n")
            {
                break;
            }
        }
    }
}


    public abstract class Database
    {
        protected Logger _logger = null;

        protected Database()
        {
            _logger = Logger.GetLogger();
        }

        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();

        protected abstract string GetDatabaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"Insert done in {GetDatabaseName()} db");
        }
        
        public void Update()
        {
            DoUpdate();
            _logger.Log($"Update done in {GetDatabaseName()} db");
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log($"Delete done in {GetDatabaseName()} db");
        }
    }

    public class DatabaseFactory
    {
        public Database GetSomeDataBase(int dbchoice)
        {
            Database obj = null;

            switch(dbchoice)
            {
                case 1:
                    obj = new MySqlServer();
                    break;
                case 2:
                    obj = new OracleServer();
                    break;
                case 3:
                    obj = new SqlServer();
                    break;
                default:
                    obj = null;
                    break;
            }

            return obj;
        }
    }


    public class MySqlServer : Database
    {
        protected override void DoInsert()
        {
            Console.WriteLine("Insert operation done for MySql Db");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Update operation done for MySql Db");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete operation done for MySql Db");
        }

        protected override string GetDatabaseName()
        {
            return "MySql Server";
        }
    }

    public class OracleServer : Database
    {
        protected override void DoInsert()
        {
            Console.WriteLine("Insert operation done for Oracle Db");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Update operation done for Oracle Db");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete operation done for Oracle Db");
        }

        protected override string GetDatabaseName()
        {
            return "Oracle Server";
        }
    }

    public class SqlServer : Database
    {
        protected override void DoInsert()
        {
            Console.WriteLine("Insert operation done for Sql Db");
        }

        protected override void DoUpdate()
        {
            Console.WriteLine("Update operation done for Sql Db");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Delete operation done for Sql Db");
        }

        protected override string GetDatabaseName()
        {
            return "Sql Server";
        }
    }

    public class Logger
    {
        private static Logger _logger1 = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger Object get Created.....");
        }

        public static Logger GetLogger()
        {
            return _logger1;
        }

        public void Log(string msg)
        {
            Console.WriteLine($"----Log : {msg} at {DateTime.Now.ToString()}");
        }
    }
}
