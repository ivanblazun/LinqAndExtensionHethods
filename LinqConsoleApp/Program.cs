using System;
using System.Collections.Generic;
using TCPdata;
using TCPextensions;
using System.Linq;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employeeList = Data.GetEmployees();

            //var filteredEmployees = employeeList.Filter(emp => emp.AnnualSalary > 30000);

            //foreach (var employee in filteredEmployees)
            //{
            //    Console.WriteLine($"First Name: {employee.FirstName}");
            //    Console.WriteLine($"Last Name: {employee.LastName}");
            //    Console.WriteLine($"Anual salary: {employee.AnnualSalary}");
            //    Console.WriteLine($"Is manager: {employee.IsManager}");
            //    Console.WriteLine();

            //}

            //List<Departement> departementList = Data.GetDepartements();

            //var filteredDepartements = departementList.Where(dep => dep.ShortName=="HR" || dep.ShortName == "FN");

            //foreach (var dep in filteredDepartements)
            //{
            //    Console.WriteLine($"{dep.ShortName}");
            //    Console.WriteLine($"{dep.LongName}");
            //    Console.WriteLine($"{dep.Id}");

            //    Console.WriteLine();

            //}

            List<Employee> employeeList = Data.GetEmployees();
            List<Departement> departementList = Data.GetDepartements();

            var results = from emp in employeeList
                          join dept in departementList
                          on emp.DepartementId equals dept.Id
                          select new
                          {
                              FirstName = emp.FirstName,
                              LastName = emp.LastName,
                              AnnualSalary = emp.AnnualSalary,
                              IsManager = emp.IsManager,
                              Departement=dept.LongName
                          };

            foreach (var result in results)
            {
                Console.WriteLine($"First Name: {result.FirstName}");
                Console.WriteLine($"Last Name: {result.LastName}");
                Console.WriteLine($"Anual salary: {result.AnnualSalary}");
                Console.WriteLine($"Is manager: {result.IsManager}");
                Console.WriteLine($"Is manager: {result.Departement}");
            
                Console.WriteLine();

            }

            var avarageSalary = results.Average(a => a.AnnualSalary);
            var maxSalary = results.Max(a => a.AnnualSalary);
            var lowestSalary = results.Min(a => a.AnnualSalary);

            Console.WriteLine($"Is manager: {avarageSalary}");
            Console.WriteLine($"Is manager: {maxSalary}");
            Console.WriteLine($"Is manager: {lowestSalary}");

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
