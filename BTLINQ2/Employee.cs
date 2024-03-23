using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLINQ2
{
    class Employee
    {
        public string name { get; set; }
        public string decription { get; set; }
        public int age { get; set; }
        public Posision posision { get; set; }
        public Department department { get; set; }

        public Employee(string name, string decription, int age, Posision posision, Department department)
        {
            this.name = name;
            this.decription = decription;
            this.age = age;
            this.posision = posision;
            this.department = department;
            department.AddEmployee(this);
            posision.AddEmployee(this);
        }
    }
}
