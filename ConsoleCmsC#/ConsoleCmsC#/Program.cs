namespace ConsoleCmsCS
{
    class Program
    {
        static int STATE = 0;
        static void Main(string[] args)
        {

            MenuController menu = new MenuController();

            Console.WriteLine("========== Management CMS ==========\n");

            switch (STATE)
            {
                case 0:
                    menu.StartupMenu();
                    break;
            }
        }
    }

}