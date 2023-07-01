using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        string employeeNumber { get; set; }
        string employeeFirstName { get; set; }
        string employeeLastName { get; set; }
        string dateOfHire { get; set; }
        string jobDescription { get; set; }
        string department { get; set; }
        double monthlySalary { get; set; }

        //Constructors
        public Employee(string firstName, string lastName)
        {
            employeeFirstName = firstName;
            employeeLastName = lastName;
        }
        public Employee(string number, string firstName, string lastName, string date, string description, string unit, double salary) {
            employeeNumber = number;
            employeeFirstName = firstName;
            employeeLastName = lastName;
            dateOfHire = date;
            jobDescription = description;
            department = unit;
            monthlySalary = salary;
        }

        public string getFullName() { 
            return employeeFirstName + " " + employeeLastName;
        }

        public string getFullNameForSorting() { 
            return employeeLastName + ", " + employeeFirstName;
        }
    }
}
