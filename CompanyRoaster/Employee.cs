﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyRoaster
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Employee(string name, decimal salary, string position, string department)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
        }
    }
}
