using EFCodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly AppDbContext _context;

        public SinhVienController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Truy vấn SinhVien thuộc khoa CNTT và có tuổi từ 18 đến 20
            var sinhViens = _context.SinhViens
                .Include(s => s.Lop)
                .Include(e => e.Lop.Khoa)
                .Where(sv => sv.Lop.Khoa.Ten == "CNTT" && sv.Tuoi >= 18 && sv.Tuoi <= 20)
                .ToList();

            return View(sinhViens);
        }
    }
}
