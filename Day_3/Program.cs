namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1.Cola , 2.Tea ");
            int choice = Convert.ToInt32(Console.ReadLine());

            DrinkObjFactory drobjf = new DrinkObjFactory();

            IDrink idobj = drobjf.GetSomeDrink(choice);

            Console.WriteLine($"Enjoy Your Drink : {idobj.GetDrink()}");

        }
    }

    public interface IDrink
    {
        string GetDrink();
    }

    public class DrinkObjFactory
    {
        public IDrink GetSomeDrink(int choice)
        {

            switch (choice)
            {

                case 1:
                    return new ColdDrink();
                    break;

                case 2:
                    return new HotDrink();
                    break;
                case 3:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            return null;
        }
    }

    public class ColdDrink : IDrink
    {
        public string GetDrink()
        {
            return "Cola";
        }
    }

    public class  HotDrink : IDrink 
    {
        public string GetDrink()
        {
            return "Tea";
        }
    }
}
