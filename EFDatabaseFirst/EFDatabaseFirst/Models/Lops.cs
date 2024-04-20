using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class Lops
    {
        public Lops()
        {
            SinhViens = new HashSet<SinhViens>();
        }

        public int Id { get; set; }
        public string Ten { get; set; }
        public int KhoaId { get; set; }

        public virtual Khoas Khoa { get; set; }
        public virtual ICollection<SinhViens> SinhViens { get; set; }
    }
}
