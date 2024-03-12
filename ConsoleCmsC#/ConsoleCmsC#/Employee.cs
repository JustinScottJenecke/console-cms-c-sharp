using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCmsCS
{
    class Employee
    {
        private int EmployeeId { get; set;}
        private string Name { get; set; }
        private string Role { get; set; }

        public Employee(int eID, string name, string role)
        {
            this.EmployeeId = eID;
            this.Name = name;
            this.Role = role;
        }

        public static string employeeDisplayHeaderRow()
        {
            return " ID): \t|\t Employee Name: \t|\t Role:";
        }
        public string employeeToString() {
            return $" {this.EmployeeId}) \t|\t {this.Name} \t|\t {this.Role}";
        }
    }
}
