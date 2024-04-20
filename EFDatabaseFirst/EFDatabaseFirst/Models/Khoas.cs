using System;
using System.Collections.Generic;

namespace EFDatabaseFirst.Models
{
    public partial class Khoas
    {
        public Khoas()
        {
            Lops = new HashSet<Lops>();
        }

        public int Id { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<Lops> Lops { get; set; }
    }
}
