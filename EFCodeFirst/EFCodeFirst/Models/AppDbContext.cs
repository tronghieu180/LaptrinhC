using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EFCodeFirst.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<SinhVien> SinhViens {get ; set; }
        public DbSet<Khoa> khoas { get; set; }
        public DbSet<Lop> lops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var khoa = new Khoa { Id = 1, Ten = "CNTT" };
            var lop = new Lop { Id = 1, Ten = "Lop1", KhoaId = khoa.Id }; // Đảm bảo KhoaId được thiết lập
            var sinhVien = new SinhVien { Id = 1, Ten = "SinhVien1", Tuoi = 20, LopId = lop.Id };

            modelBuilder.Entity<Khoa>().HasData(khoa); // Thêm dữ liệu seed cho Khoa
            modelBuilder.Entity<Lop>().HasData(lop);   // Thêm dữ liệu seed cho Lop
            modelBuilder.Entity<SinhVien>().HasData(sinhVien);

            var khoa1 = new Khoa { Id = 2, Ten = "XayDung" };
            var lop1 = new Lop { Id = 2, Ten = "Lop2", KhoaId = khoa1.Id }; // Đảm bảo KhoaId được thiết lập
            var sinhVien1 = new SinhVien { Id = 2, Ten = "SinhVien2", Tuoi = 20, LopId = lop1.Id };

            modelBuilder.Entity<Khoa>().HasData(khoa1); // Thêm dữ liệu seed cho Khoa
            modelBuilder.Entity<Lop>().HasData(lop1);   // Thêm dữ liệu seed cho Lop
            modelBuilder.Entity<SinhVien>().HasData(sinhVien1);
        }
    }
}
