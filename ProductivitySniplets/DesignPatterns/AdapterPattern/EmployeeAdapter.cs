using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public interface IEmployeeManager
    {
        string GetEmployess();
    }

    public class EmployeeAdapter : EmployeeManager, IEmployeeManager
    {
        public override string GetEmployess()
        {
            var csv = base.GetEmployess();
            var pipe = csv.Replace(",", "|");
            return pipe;
        }
    }
}