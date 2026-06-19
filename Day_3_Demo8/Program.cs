namespace Day_3_Demo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Your Choice : 1.PDF , 2.DOCX , 3.EXCEL , 4.JSON , 5.XML");
                int choice = Convert.ToInt32(Console.ReadLine());

                DataReportFactory drf = new DataReportFactory();
                Report somereport = drf.GetSomeReport(choice);

                somereport.GenerateReport();

                Console.WriteLine("Do you want to continue? y/n");
                string ynChoice = Console.ReadLine().ToLower();
                if(ynChoice == "n")
                {
                    break;
                }
            }
        }
    }

    public abstract class Report
    {
        protected abstract void Parse();

        protected abstract void Validate();

        protected abstract void Save();

        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();
        }
    }

    public abstract class SpecialReport : Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }

    public class DataReportFactory
    {
        public Report GetSomeReport(int ch)
        {
            Report report = null;
            switch(ch)
            {
                case 1:
                    report = new PDF();
                    break;
                case 2:
                    report = new DOCX();
                    break;
                case 3:
                    report = new EXCEL();
                    break;
                case 4:
                    report = new JSON();
                    break;
                case 5:
                    report = new XML();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            return report;
        }
    }
    public class PDF : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
        }
    }

    public class EXCEL : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("EXCEL Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("EXCEL Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("EXCEL Saved");
        }
    }

    public class DOCX : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("DOCX Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("DOCX Saved");
        }
    }

    public class JSON : SpecialReport
    {
        protected override void Parse()
        {
            // pdf parsing logic..
            Console.WriteLine("JSON Parsed!");
        }
        protected override void Validate()
        {
            // pdf parsing logic..
            Console.WriteLine("JSON Validated!");
        }

        protected override void ReValidate()
        {
            // pdf parsing logic..
            Console.WriteLine("JSON Re-Validated!");
        }

        protected override void Save()
        {
            // pdf parsing logic..
            Console.WriteLine("JSON Saved!");
        }
    }

    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            // pdf parsing logic..
            Console.WriteLine("XML Parsed!");
        }
        protected override void Validate()
        {
            // pdf parsing logic..
            Console.WriteLine("XML Validated!");
        }

        protected override void ReValidate()
        {
            // pdf parsing logic..
            Console.WriteLine("XML Re-Validated!");
        }

        protected override void Save()
        {
            // pdf parsing logic..
            Console.WriteLine("XML Saved!");
        }

    }
}
