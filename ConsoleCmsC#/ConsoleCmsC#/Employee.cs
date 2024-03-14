using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCmsCS
{
    public class Employee
    {
        private int EmployeeId { get; set;}
        private string Name { get; set; }
        private string Role { get; set; }
        private decimal Salary { get; set; }

        public Employee(int eID, string name, string role, decimal amount)
        {
            this.EmployeeId = eID;
            this.Name = name;
            this.Role = role;
            this.Salary = amount;
        }

        public bool IdAlreadyExists(int idInput) 
        {
            return idInput == this.EmployeeId ? true : false;
        }

        public string employeeToString() 
        {
            return $" {this.EmployeeId}) \t| {this.Name} \t\t\t| {this.Role} \t\t R{this.Salary} \n";
        }
    }
}
