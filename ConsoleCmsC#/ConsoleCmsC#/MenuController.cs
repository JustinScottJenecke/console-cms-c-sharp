using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCmsCS
{
    public class MenuController
    {
        private List<Employee> Employees { get; set; }

        public MenuController()
        {
            Employees = new List<Employee> {
                new Employee(1, "Jade Burgess", "CEO"),
                new Employee(2, "Wesley Erasmus", "Intern"),
                new Employee(3, "William King", "Senior"),
                new Employee(4, "Sammy Kazadi", "Junior"),
                new Employee(5, "Roy Hilson", "Junior")
            };
        }

        public string DisplayEmployeeMenu(List<Employee> employees)
        {
            string menuString = "";

            foreach (Employee employee in employees)
            {
                menuString += employee.employeeToString();
            }
/*
            return " " +
                "ID: \t|\t Employee Name: \t|\t Role:" +
                "";*/
        }
    }
}
