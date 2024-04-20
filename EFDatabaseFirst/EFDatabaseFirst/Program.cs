using EFDatabaseFirst.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace EFDatabaseFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Khởi tạo dịch vụ host
            var host = CreateHostBuilder(args).Build();

            // Tạo một scope để sử dụng DbContext
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    // Lấy DbContext từ dịch vụ
                    var context = services.GetRequiredService<CodeFirstContext>();

                    // Truy vấn dữ liệu và hiển thị kết quả
                    var sinhViens = context.SinhViens
                        .Include(s => s.Lop)
                        .Include(e => e.Lop.Khoa)
                        .Where(sv => sv.Lop.Khoa.Ten == "CNTT" && sv.Tuoi >= 18 && sv.Tuoi <= 20)
                        .ToList();

                    foreach (var sv in sinhViens)
                    {
                        Console.WriteLine($"Tên: {sv.Ten}, Tuổi: {sv.Tuoi}, Lớp: {sv.Lop.Ten}, Khoa: {sv.Lop.Khoa.Ten}");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            // Chạy ứng dụng
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
