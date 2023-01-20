using System;
using System.Collections.Generic;
using TCPdata;
using TCPextensions;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();

            var filteredEmployees = employeeList.Filter(emp => emp.AnnualSalary > 30000);

            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine($"First Name: {employee.FirstName}");
                Console.WriteLine($"Last Name: {employee.LastName}");
                Console.WriteLine($"Anual salary: {employee.AnnualSalary}");
                Console.WriteLine($"Is manager: {employee.IsManager}");
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
