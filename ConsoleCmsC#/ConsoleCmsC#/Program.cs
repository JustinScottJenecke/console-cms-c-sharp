namespace ConsoleCmsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Management CMS ==========\n");
            MenuController menu = new MenuController();

            menu.renderMenu();

        }
    }

}