using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailys.DesignPatterns
{
    public class EmployeeBuilder
    {
        protected Employee _employee;

        public EmployeeBuilder()
        {
            _employee = new Employee();
        }

        public EmployeeBuilder SetName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeBuilder SetDepartment(string department)
        {
            _employee.Department = department;
            return this;
        }

        public EmployeeBuilder Setposition(string position)
        {
            _employee.Position = position;
            return this;
        }

        public Employee build() => _employee;
    }
}
