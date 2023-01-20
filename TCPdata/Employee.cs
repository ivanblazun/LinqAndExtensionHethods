using System;
using System.Collections.Generic;
using System.Text;

namespace TCPdata
{
    public class Employee
    {
  
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartementId { get; set; }
    }

}
