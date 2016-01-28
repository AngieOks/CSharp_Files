using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment2_240412
{
    class Employee
    {
        private int id;              // The class properties: id,name,surname and salary declared
        private string firstName;
        private string lastName;
        private double salary;

        // first constructor
        public Employee()
        {
            id = 0;                  //initializing an object instance with no details
            firstName = "";
            lastName = "";
            salary = 0.0;
        }

        // second constructor      //initializing an object instance with no salary
        public Employee(int idValue, string firstNameVal, string lastNameVal)
        {
            id = idValue;
            firstName = firstNameVal;
            lastName = lastNameVal;
            salary = 0.0;
        }

        // third constructor        //initializing an object instance with all details
        public Employee(int idValue, string firstNameVal,string lastNameVal, double salaryValue)
        {   
            id = idValue;
            firstName = firstNameVal;
            lastName = lastNameVal;
            salary = salaryValue;
        }

        public int idNum
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public string employeeToString()     //Method that returns the employees details as a string 
        {
            return (Convert.ToString(id) + " " + " " + firstName +" " + lastName + " " + " " 
            + "£ " + salary.ToString("F2")); // Adds the £ sign and gives the value of salary
                                             // in 2 decimal places (".00")
        }

    }
}
