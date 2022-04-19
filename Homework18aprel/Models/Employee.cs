using System;
using System.Collections.Generic;
using System.Text;

namespace Homework18aprel.Models
{
    class Employee
    {
        public static int Id = 1;
        public int No;
        public string FullName;
       private double Salary;
        public string Position;
        public Employee()
        {
            No = Id;
            Id++;


        }
    }
}
