namespace Day_4_Demo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee emp = new Employee();
            emp.Eid = 100;
            Console.WriteLine(emp.Eid);

            emp.Ename = "Pranav";
            Console.WriteLine(emp.Ename);

            emp.IsActive = true;
            Console.WriteLine(emp.IsActive);

            HR obj = new HR();
            obj.HRName = "Sanket";

            emp.HREmp = obj;

            HR hrObj = emp.HREmp;
            Console.WriteLine($"Hr Name = {hrObj.HRName}");
            Console.WriteLine($"Hr Name = {emp.HREmp.HRName}");
        }
    }

    public class Employee
    {
        private int _eid;
        private string _ename;
        private bool _isActive;
        private HR _HREmp;
        private string[] _Days;

        public string[] WeekDays
        {
            set { _Days = value; }
            get { return _Days; }
        }

        public int Eid
        {   
            set
            {
                if (value == 100)
                    _eid = value;
                else
                    _eid = 0;

            }
            get
            {
                if (_eid == 100)
                    return _eid + 10;
                else
                    return _eid * 0;
            }
        }
        public string Ename
        {
            set { _ename = value; } 
            get
            {
                return $"Mr/Mrs. {_ename}";
            }
        }

        public bool IsActive
        {
            set {  _isActive = value; }
            get { return _isActive; }
        }

        public HR HREmp
        {
            set { _HREmp = value; }
            get { return _HREmp; }
        }
    }

    public class HR
    {
        private string _HRName;
        public string HRName
        {
            get { return _HRName; }
            set { _HRName = value; }
        }
    }
}
