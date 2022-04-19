using Homework18aprel.Models;
using System;

namespace Homework18aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee();
            Employee1.FullName = "Aliyev Ali";
            Employee1.Position = "Developer";

            Employee Employee2 = new Employee();
            Employee2.FullName = "Valiyev Vali";
            Employee2.Position = "Teacher";

            Employee Employee3 = new Employee();
            Employee3.FullName = "Babayeva Zivar";
            Employee3.Position = "Developer";

            Employee Employee4 = new Employee();
            Employee4.FullName = "Alizada Sona";
            Employee4.Position = "Engineer";

            string CompanyName = "Code Academy";
            bool checkChr = CompanyName.CheckChar('n');

            Console.WriteLine(checkChr);
            Company company = new Company { Name = "Sssss", Limit = 6 };
            company.AddEmployee(Employee1);
            company.AddEmployee(Employee2);
            company.AddEmployee(Employee3);
            company.AddEmployee(Employee4);

            foreach (Employee item in company.GetEmployees())
            {
                Console.WriteLine($"Nomresi:{item.No}Fullname-i:{item.FullName} Vezifesi:{item.Position}");
            }
        }
    }
}
