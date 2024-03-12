using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCmsCS
{
    public class MenuController
    {
        public List<Employee> Employees { get; set; }
        public Templates Templates { get; set; }

        public MenuController()
        {
            this.Templates = new Templates();

            Employees = new List<Employee> {
                new Employee(1, "Jade Burgess", "CEO", 50000.00m),
                new Employee(2, "Wes Erasmus", "Intern", 5000.00m),
                new Employee(3, "William King", "Senior", 42000.00m),
                new Employee(4, "Sammy Kazadi", "Junior", 20000.00m),
                new Employee(5, "Roy Hilson", "Junior", 25000.00m)
            };

        }

        public void StartupMenu() {

            Console.WriteLine(this.Templates.EmployeeTableTemplate(this.Employees));
            Console.WriteLine("");
            Console.WriteLine(this.Templates.MainMenuTemplate());

        }

        public void AddEmployee(List<Employee> employees)
        {
            int phase = 1;

            string newName = "";
            string newRole = "";
            decimal newSalary = 0m;

            while (phase == 1)
            {
                Console.Clear();
                Console.Write("Enter new employee name and surname: ");
                newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                { 
                    phase++;
                }
                else
                { 
                    Console.WriteLine("User employee name and surname cannot be empty.. ");
                    Console.ReadKey();
                }
            }

            while (phase == 2)
            {
                Console.Clear();
                Console.Write("Enter new employee role: ");
                newRole = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newRole))
                {
                    phase++;
                }
                else
                {
                    Console.WriteLine("User role cannot be empty.. ");
                    Console.ReadKey();
                }
            }

            while (phase == 3)
            {
                Console.Clear();
                Console.Write("Enter new employee monthly salary: ");

                bool conversionSuccess = decimal.TryParse(Console.ReadLine(), out newSalary);

                if (conversionSuccess)
                {
                    phase++;
                } else
                {
                    Console.WriteLine("Please enter a valid number as salary input");
                    Console.ReadKey();
                }
            }

            Console.Clear();
            Console.WriteLine(new Employee(
                employees.Count, 
                newName, 
                newRole, 
                newSalary
                )
                .employeeToString());
        }

    }
}
