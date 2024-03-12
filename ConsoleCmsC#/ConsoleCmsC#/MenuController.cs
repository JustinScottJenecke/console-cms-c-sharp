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

        public MenuController()
        {
            Employees = new List<Employee> {
                new Employee(1, "Jade Burgess", "CEO", 50000.00m),
                new Employee(2, "Wes Erasmus", "Intern", 5000.00m),
                new Employee(3, "William King", "Senior", 42000.00m),
                new Employee(4, "Sammy Kazadi", "Junior", 20000.00m),
                new Employee(5, "Roy Hilson", "Junior", 25000.00m)
            };
        }

        public string DisplayEmployeeTable(List<Employee> employees)
        {
            string menuString = "";

            foreach (Employee employee in employees)
            {
                menuString += employee.employeeToString();
            }
            //Console.WriteLine(menuString);
            return " " +
                "----- Employee List -----\n" +
                "ID: \t| Employee Name: \t\t| Role: \n" + menuString;
        }
    }
}
