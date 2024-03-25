using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi_gk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaiLieu> taiLieus = new List<TaiLieu>
        {
            new Sach { MaXuatBan = "1", TenTaiLieu = "Sach 1", NhaPhatHanh = "Nha Xuat Ban A", MaDanhMuc = "S", TenTacGia = "Tac Gia 1", SoTrang = 100 },
            new Sach { MaXuatBan = "2", TenTaiLieu = "Sach 2", NhaPhatHanh = "Nha Xuat Ban B", MaDanhMuc = "S", TenTacGia = "Tac Gia 2", SoTrang = 150 },
            new TapChi { MaXuatBan = "3", TenTaiLieu = "Tap Chi 1", NhaPhatHanh = "Nha Xuat Ban C", MaDanhMuc = "TC", SoPhatHanh = 1, TrangPhatHanh = 20 },
            new TapChi { MaXuatBan = "4", TenTaiLieu = "Tap Chi 2", NhaPhatHanh = "Nha Xuat Ban D", MaDanhMuc = "TC", SoPhatHanh = 2, TrangPhatHanh = 25 },
            new Bao { MaXuatBan = "5", TenTaiLieu = "Bao 1", NhaPhatHanh = "Nha Xuat Ban E", MaDanhMuc = "B", NgayPhatHanh = new DateTime(2024, 3, 1) },
            new Bao { MaXuatBan = "6", TenTaiLieu = "Bao 2", NhaPhatHanh = "Nha Xuat Ban F", MaDanhMuc = "B", NgayPhatHanh = new DateTime(2024, 3, 15) }
        };

            // Thêm mới một sách vào danh sách tài liệu
            taiLieus.Add(new Sach { MaXuatBan = "7", TenTaiLieu = "Sach 3", NhaPhatHanh = "Nha Xuat Ban G", MaDanhMuc = "S", TenTacGia = "Tac Gia 3", SoTrang = 200 });
            taiLieus.Add(new Bao { MaXuatBan = "8", TenTaiLieu = "Bao 8", NhaPhatHanh = "Nha Xuat Ban G", MaDanhMuc = "B", NgayPhatHanh = new DateTime(2024, 9, 24) });
            taiLieus.Add(new TapChi { MaXuatBan = "9", TenTaiLieu = "Tap Chi 9", NhaPhatHanh = "Nha Xuat Ban y", MaDanhMuc = "TC", SoPhatHanh = 5, TrangPhatHanh = 78 });

            var sach = taiLieus.OfType<Sach>();

            Console.WriteLine("Danh sách sách:");
            foreach (var s in sach)
            {
                Console.WriteLine($"{s.MaXuatBan} - {s.TenTaiLieu}");
            }

            // Lọc ra các tạp chí
            var tapChi = taiLieus.OfType<TapChi>();

            Console.WriteLine("\nDanh sách tạp chí:");
            foreach (var tc in tapChi)
            {
                Console.WriteLine($"{tc.MaXuatBan} - {tc.TenTaiLieu}");
            }

            // Lọc ra các báo
            var bao = taiLieus.OfType<Bao>();

            Console.WriteLine("\nDanh sách báo:");
            foreach (var b in bao)
            {
                Console.WriteLine($"{b.MaXuatBan} - {b.TenTaiLieu}");
            }

            // Tìm tài liệu theo loại
            Console.WriteLine("Chon loai can tim (S, B, TC): ");
            string loaiCanTim = Console.ReadLine(); ;
            var taiLieusTheoLoai = taiLieus.Where(tl => tl.MaDanhMuc == loaiCanTim);
            Console.WriteLine($"Danh sách tài liệu loại {loaiCanTim}:");
            foreach (var tl in taiLieusTheoLoai)
            {
                Console.WriteLine($"{tl.MaXuatBan} - {tl.TenTaiLieu}");
            }

            // Tìm báo có ngày phát hành là tháng 3 năm 2024
            var baoTrongThang3_2024 = taiLieus.OfType<Bao>().Where(b => b.NgayPhatHanh.Month == 3 && b.NgayPhatHanh.Year == 2024);
            Console.WriteLine("\nBáo có ngày phát hành là tháng 3 năm 2024:");
            foreach (var b in baoTrongThang3_2024)
            {
                Console.WriteLine($"{b.MaXuatBan} - {b.TenTaiLieu}");
            }
            Console.ReadLine();
        }
    }
}

