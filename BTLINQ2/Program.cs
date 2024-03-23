using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Department hrdepartment = new Department("Human Resource");
            Department itdepartment = new Department("Information Technology");
            Posision managerps = new Posision("Manager");
            Posision engineerps = new Posision("Engineer");
            Posision directorps = new Posision("Director");
            Employee employee1 = new Employee("Hieu", "Director", 38, directorps, itdepartment);
            Employee employee2 = new Employee("Tien", "Manager", 30, managerps, hrdepartment);
            Employee employee3 = new Employee("Phuong", "Engineer", 26, engineerps, itdepartment);
            Employee employee4 = new Employee("Thinh", "Engineer", 25, engineerps, itdepartment);
            Console.WriteLine("Nhap tu khoa tim kiem: ");
            string keyword = Console.ReadLine();
            Console.WriteLine("Tuoi tu: ");
            int begin_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Den tuoi: ");
            int end_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vi tri: ");
            string positionKeyword = Console.ReadLine();
            Console.WriteLine("Phong ban: ");
            string departmentKeyword = Console.ReadLine();

            Console.WriteLine("\nKết quả tìm kiếm:");
            var results = from department in new Department[] { hrdepartment, itdepartment }
                          from employee in department.Employees
                          where (employee.name.Contains(keyword) || employee.decription.Contains(keyword)) &&
                                employee.age >= begin_age && employee.age <= end_age &&
                                (employee.posision.title.Contains(positionKeyword) || employee.department.name.Contains(departmentKeyword))
                          select employee;
            foreach (var employee in results)
            {
                Console.WriteLine($"{employee.name} ({employee.decription}) - Age: {employee.age}, Position: {employee.posision.title}, Department: {employee.department.name}");
            }
            Console.ReadLine();
        }
    }
}
