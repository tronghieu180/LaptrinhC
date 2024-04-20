using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFDatabaseFirst.Models
{
    public partial class CodeFirstContext : DbContext
    {
        public CodeFirstContext()
        {
        }

        public CodeFirstContext(DbContextOptions<CodeFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Khoas> Khoas { get; set; }
        public virtual DbSet<Lops> Lops { get; set; }
        public virtual DbSet<SinhViens> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CHN9OB7\\SQLEXPRESS;Initial Catalog=CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoas>(entity =>
            {
                entity.ToTable("khoas");
            });

            modelBuilder.Entity<Lops>(entity =>
            {
                entity.ToTable("lops");

                entity.HasIndex(e => e.KhoaId);

                entity.HasOne(d => d.Khoa)
                    .WithMany(p => p.Lops)
                    .HasForeignKey(d => d.KhoaId);
            });

            modelBuilder.Entity<SinhViens>(entity =>
            {
                entity.ToTable("sinhViens");

                entity.HasIndex(e => e.LopId);

                entity.HasOne(d => d.Lop)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.LopId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
