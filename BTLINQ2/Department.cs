using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLINQ2
{
    class Department
    {
        public string name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string name)
        {
            this.name = name;
            Employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
