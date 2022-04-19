using System;
using System.Collections.Generic;
using System.Text;

namespace Homework18aprel.Models
{
    class Company
    {
        public string Name { get; set; }
        public int Limit { get; set; }
        private Employee[] _employees;
       
        public Company()
        {
            _employees = new Employee[0];
        }
        public void AddEmployee(Employee employee)
        {
            if (_employees.Length < Limit)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
                return;
            }
            Console.WriteLine("Company-de max isci sayi var");
        }
        public Employee[] GetEmployees() => _employees;
    }
}
