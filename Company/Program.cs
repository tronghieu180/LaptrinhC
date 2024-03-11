using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{

    class Program
    {
        public static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }
        static void Main(string[] args)
        {
            List<Department> departments = Department.GetDepartments();
            List<Employee> employees = Employee.GetEmployees();
            int max = employees.Max(emp => emp.Salary);
            int min = employees.Min(emp => emp.Salary);
            double average = employees.Average(emp => emp.Salary);
            Console.WriteLine($"Luong cao nhat: {max}");
            Console.WriteLine($"Luong thap nhat: {min}");
            Console.WriteLine($"Luong trung binh: {average}");
            Console.Write("\n");


            Console.WriteLine("Inner Join");
            var innerjoin = from e in Employee.GetEmployees()
                         join d in Department.GetDepartments()
                         on e.ID equals d.ID
                         select new
                         {
                             EmployeeName = e.Name,
                             DepartmentName = d.Name
                         };
            foreach (var employee in innerjoin)
            {
                Console.WriteLine("{0}, {1}", employee.EmployeeName, employee.DepartmentName);
            }
            Console.Write("\n");

            Console.WriteLine("Join Group");
            var joinGroupQuery = from e in employees
                                 join d in departments on e.ID equals d.ID
                                 group e by d.Name into grouped
                                 select new
                                 {
                                     Department = grouped.Key,
                                     Employees = grouped.ToList()
                                 };

            Console.WriteLine("Nhan vien duoc gop theo phong ban:");
            foreach (var group in joinGroupQuery)
            {
                Console.WriteLine($"Department: {group.Department}");
                foreach (var emp in group.Employees)
                {
                    Console.WriteLine($"\t{emp.Name}");
                }
            }
            Console.Write("\n");

            Console.WriteLine("Join left");
            var leftJoinQuery = from e in employees
                                join d in departments on e.ID equals d.ID into employeeDept
                                from ed in employeeDept.DefaultIfEmpty()
                                select new
                                {
                                    EmployeeName = e.Name,
                                    DepartmentName = ed != null ? ed.Name : "No Department"
                                };

            Console.WriteLine("\nLeft Join:");
            foreach (var item in leftJoinQuery)
            {
                Console.WriteLine("{0}--{1}", item.EmployeeName, item.DepartmentName);
            }
            Console.Write("\n");

            Console.WriteLine("Right join");
            var rightJoinQuery = from dept in departments
                                 join emp in employees on dept.ID equals emp.ID into departmentEmployee
                                 from de in departmentEmployee.DefaultIfEmpty()
                                 select new
                                 {
                                     DepartmentName = dept.Name,
                                     EmployeeName = de != null ? de.Name : "No Employee"
                                 };

            Console.WriteLine("\nRight Join:");
            foreach (var item in rightJoinQuery)
            {
                Console.WriteLine("{0}---{1}", item.DepartmentName, item.EmployeeName);
            }

            Console.Write("\n");

            Console.WriteLine("Max min tuoi: ");
            int maxAge = employees.Max(emp => CalculateAge(emp.Birthday));
            int minAge = employees.Min(emp => CalculateAge(emp.Birthday));
            Console.WriteLine($"Tuổi cao nhất: {maxAge}");
            Console.WriteLine($"Tuổi thấp nhất: {minAge}");
            Console.ReadLine();
        }

        
    }
}
