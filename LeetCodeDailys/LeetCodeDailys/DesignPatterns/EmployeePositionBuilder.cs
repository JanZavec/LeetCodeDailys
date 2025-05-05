using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailys.DesignPatterns
{
    public class EmployeePositionBuilder<T> : EmployeeBuilder where T: EmployeePositionBuilder<T>
    {
        public EmployeePositionBuilder<T> Setposition(string position)
        {
            _employee.Position = position;
            return (T)this;
        }
    }
}
