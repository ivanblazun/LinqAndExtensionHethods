using System;
using System.Collections.Generic;
using System.Text;

namespace TCPdata
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartementId = 1
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jamson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartementId = 2
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Amiston",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartementId = 2
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Ste3vens",
                AnnualSalary = 40000.3m,
                IsManager = false,
                DepartementId = 3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Departement> GetDepartements() 
        {
            List<Departement> departements = new List<Departement>();

            Departement departement = new Departement
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departements.Add(departement);

            departement = new Departement
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"
            };
            departements.Add(departement);
            
            departement = new Departement
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology"
            };
            departements.Add(departement);
            return departements;
        }
    }
}
