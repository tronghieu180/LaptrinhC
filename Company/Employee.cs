using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public DateTime Birthday  { get; set; } 
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>() { 
                new Employee{ID = 1, Name = "A", Age = 30, Salary = 100000, Birthday = new DateTime(1997, 10, 20)},
                new Employee{ID = 2, Name = "B", Age = 31, Salary = 200000, Birthday = new DateTime(1996, 10, 20)},
                new Employee{ID = 3, Name = "C", Age = 32, Salary = 300000, Birthday = new DateTime(1995, 10, 20)},
                new Employee{ID = 4, Name = "D", Age = 33, Salary = 400000, Birthday = new DateTime(1994, 10, 20)},
                new Employee{ID = 5, Name = "E", Age = 34, Salary = 500000, Birthday = new DateTime(1993, 10, 20)},
            };
        }

    }
}
