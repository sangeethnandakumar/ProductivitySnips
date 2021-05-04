using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class EmployeeManager
    {
        public List<string> Employees { get; set; }

        public EmployeeManager()
        {
            Employees = new List<string>();
            Employees.Add("Employee A");
            Employees.Add("Employee B");
            Employees.Add("Employee C");
            Employees.Add("Employee D");
        }

        public virtual string GetEmployess()
        {
            return string.Join(',', Employees);
        }
    }
}