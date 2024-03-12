using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCmsCS
{
    public class Templates
    {
        public string MainMenuTemplate()
        {
            return "" +
                "----- Main Menu -----\n\n" +
                "1) add employee \n" +
                "2) terminate employee \n" +
                "3) assign new role \n" +
                "4) increase / decrease salary \n" +
            "";
        }

        public string EmployeeTableTemplate(List<Employee> employees)
        {
            string menuString = "";

            foreach (Employee employee in employees)
            {
                menuString += employee.employeeToString();
            }

            return " " +
                "----- Employee List -----\n" +
                "ID: \t| Employee Name: \t\t| Role: \n\n" + menuString;
        }
    }
}
