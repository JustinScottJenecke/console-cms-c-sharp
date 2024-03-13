using System.Security.Authentication;

namespace ConsoleCmsCS
{
    class Program
    {
        static int STATE = 0;
        static void Main(string[] args)
        {

            MenuController menu = new MenuController();

            while (STATE != 10) 
            {
                Console.WriteLine("========== Management CMS ==========\n");

                switch (STATE)
                {
                    case 0:
                        menu.StartupMenu();
                        Console.WriteLine("Choice: ");
                        int input = Int32.Parse(Console.ReadLine());
                        STATE = input;
                        Console.Clear();
                        break;
                    case 1:
                        menu.AddEmployee(menu.Employees);
                        STATE = 0;
                        break;
                    case 10:
                        Console.WriteLine("Closing app..");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select an operation from the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        STATE = 0;
                        break;
                }
            }
        }
    }

}