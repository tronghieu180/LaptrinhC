using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class SinhViens
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public int LopId { get; set; }

        public virtual Lops Lop { get; set; }
    }
}
