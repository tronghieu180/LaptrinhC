using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }

        // Khóa ngoại đến Lop
        public int LopId { get; set; }
        public Lop Lop { get; set; }
    }
}
