using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst.Models
{
    public class Lop
    {
        public int Id { get; set; }
        public string Ten { get; set; }

        // Khóa ngoại đến Khoa
        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }

        public ICollection<SinhVien> SinhViens { get; set; }
    }
}
