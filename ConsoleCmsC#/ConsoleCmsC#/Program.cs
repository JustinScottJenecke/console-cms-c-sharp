namespace ConsoleCmsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Management CMS");
            Employee employee1 = new Employee(1, "Jade Burgess", "Intern");

            Console.WriteLine( employee1.employeeToString() );
        }
    }

}