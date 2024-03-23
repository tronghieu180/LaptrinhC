using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLINQ2
{
    class Posision
    {
        public string title { get; set; }
        public List<Employee> Employees { get; set; }
        public Posision(string title)
        {
            this.title = title;
            Employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
    }
}
