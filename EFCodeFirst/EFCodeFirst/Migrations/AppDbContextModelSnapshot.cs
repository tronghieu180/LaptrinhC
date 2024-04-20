﻿// <auto-generated />
using EFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCodeFirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCodeFirst.Models.Khoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("khoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ten = "CNTT"
                        },
                        new
                        {
                            Id = 2,
                            Ten = "XayDung"
                        });
                });

            modelBuilder.Entity("EFCodeFirst.Models.Lop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KhoaId")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KhoaId");

                    b.ToTable("lops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            KhoaId = 1,
                            Ten = "Lop1"
                        },
                        new
                        {
                            Id = 2,
                            KhoaId = 2,
                            Ten = "Lop2"
                        });
                });

            modelBuilder.Entity("EFCodeFirst.Models.SinhVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LopId")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LopId");

                    b.ToTable("SinhViens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LopId = 1,
                            Ten = "SinhVien1",
                            Tuoi = 20
                        },
                        new
                        {
                            Id = 2,
                            LopId = 2,
                            Ten = "SinhVien2",
                            Tuoi = 20
                        });
                });

            modelBuilder.Entity("EFCodeFirst.Models.Lop", b =>
                {
                    b.HasOne("EFCodeFirst.Models.Khoa", "Khoa")
                        .WithMany("Lops")
                        .HasForeignKey("KhoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCodeFirst.Models.SinhVien", b =>
                {
                    b.HasOne("EFCodeFirst.Models.Lop", "Lop")
                        .WithMany("SinhViens")
                        .HasForeignKey("LopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
