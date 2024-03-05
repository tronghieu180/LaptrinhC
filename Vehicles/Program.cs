using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                    new Car { Id = 1, Name = "Honda",price = 200000, YearOfManufacture = 1990, hangsanxuat = "tien"},
                    new Car { Id = 2, Name = "Toyota", price = 300000, YearOfManufacture = 2024, hangsanxuat = "tien" },
                    new Car { Id = 3, Name = "Mazda", price = 125000, YearOfManufacture = 1925, hangsanxuat = "hieu" },
                    new Car { Id = 4, Name = "VinFast", price = 224000, YearOfManufacture = 2017, hangsanxuat = "hieu" },
                    new Car { Id = 5, Name = "KIA", price = 350000, YearOfManufacture = 1855 , hangsanxuat = "nghia"},
                    new Car { Id = 6, Name = "BMW", price = 150000, YearOfManufacture = 1946, hangsanxuat = "nghia" },
                    new Car { Id = 7, Name = "Merc", price = 500000, YearOfManufacture = 1981, hangsanxuat = "long" },
                    new Car { Id = 8, Name = "Abc", price = 175000, YearOfManufacture = 2000, hangsanxuat = "long" },
                    new Car { Id = 9, Name = "Def", price = 400000, YearOfManufacture = 1940 , hangsanxuat = "long"},
                    new Car { Id = 10, Name = "Gij", price = 250000, YearOfManufacture = 1944 , hangsanxuat = "tien"}
            };
            var gia = cars.Where(car => car.price >= 100000 && car.price <= 250000);
            Console.WriteLine("             Xe có giá từ 100.000 đến 250000 là: ");
            foreach(var car in gia)
            {
                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, price: {car.price}, year: {car.YearOfManufacture}, Hãng sản xuất: {car.hangsanxuat}");
            }
            var nam = cars.Where(car => car.YearOfManufacture > 1990); 
            Console.WriteLine("Xe lon hon nam 1990 là: ");
            foreach (var car in nam)
            {
                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, price: {car.price}, year: {car.YearOfManufacture}, Hãng sản xuất: {car.hangsanxuat}");
            }

            Console.WriteLine("             Cac xe theo hang san xuat la");
            var hangSales = cars.GroupBy(car => car.hangsanxuat).Select(group => new { hangsanxuat = group.Key, TotalSales = group.Sum(car => car.price) });

            foreach(var group in hangSales)
            {
                Console.WriteLine($"Hang san xuat: {group.hangsanxuat}, Tong ban: {group.TotalSales}");
            }

            List<Truck> trucks = new List<Truck> 
            {
                    new Truck { Id = 1, Name = "HINO",price = 200000, YearOfManufacture = 1990, hangsanxuat = "tien"},
                    new Truck { Id = 2, Name = "ISUZU", price = 300000, YearOfManufacture = 2024, hangsanxuat = "tien" },
                    new Truck { Id = 3, Name = "HYNDAI", price = 125000, YearOfManufacture = 1925, hangsanxuat = "hieu" },
                    new Truck { Id = 4, Name = "TATA", price = 224000, YearOfManufacture = 2017, hangsanxuat = "hieu" },
                    new Truck { Id = 5, Name = "TERACO", price = 350000, YearOfManufacture = 1855 , hangsanxuat = "nghia"},
            };

            Console.WriteLine("            Hang xe tai duoc san xuat theo nam: ");
            var sorted = trucks.OrderByDescending(truck => truck.YearOfManufacture);

            foreach(var sort in sorted)
            {
                Console.WriteLine($"Name: {sort.Name}, Year: {sort.YearOfManufacture}");
            }
           

            Console.WriteLine("                     Cac cong ty chu quan: ");
            foreach(var truck in trucks)
            {
                Console.WriteLine($"Id: {truck.Id}, Name: {truck.Name}, Hang san xuat: {truck.hangsanxuat}");
            }

            Console.ReadLine();

        }
    }
}
