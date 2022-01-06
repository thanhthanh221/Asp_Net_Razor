﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Razor.model;

namespace Razor.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220106102706_Test1")]
    partial class Test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Razor.model.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("Razor.model.HoaDon", b =>
                {
                    b.Property<int>("MaHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Mã Hóa Đơn")
                        .UseIdentityColumn();

                    b.Property<int>("MaNhanVienBan")
                        .HasColumnType("int")
                        .HasColumnName("Mã Nhân Viên Bán");

                    b.Property<int>("NguoiMua")
                        .HasColumnType("int")
                        .HasColumnName("Người Mua");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaNhanVienBan");

                    b.HasIndex("NguoiMua");

                    b.ToTable("Hóa Đơn");
                });

            modelBuilder.Entity("Razor.model.KhachHang", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CMND")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("nvarchar");

                    b.HasKey("ID");

                    b.ToTable("Nguời Mua");
                });

            modelBuilder.Entity("Razor.model.Kho", b =>
                {
                    b.Property<int>("MaKho")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Mã Kho")
                        .UseIdentityColumn();

                    b.Property<int>("TenKho")
                        .HasColumnType("int")
                        .HasColumnName("Tên Kho");

                    b.HasKey("MaKho");

                    b.ToTable("Kho");
                });

            modelBuilder.Entity("Razor.model.NhanVien", b =>
                {
                    b.Property<int>("MaNV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Mã Nhân Viên")
                        .UseIdentityColumn();

                    b.Property<int>("CMND")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Họ Tên");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NhanVienMaNV")
                        .HasColumnType("int");

                    b.Property<int>("SDT")
                        .HasColumnType("int")
                        .HasColumnName("Số Điện Thoại");

                    b.HasKey("MaNV");

                    b.HasIndex("NhanVienMaNV");

                    b.ToTable("Nhân Viên");
                });

            modelBuilder.Entity("Razor.model.Product", b =>
                {
                    b.Property<int>("MaSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Mã Sản Phẩm")
                        .UseIdentityColumn();

                    b.Property<int>("MaKho")
                        .HasColumnType("int")
                        .HasColumnName("Mã Kho");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tên Sản Phẩm");

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasColumnName("Giá");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("Số Lượng");

                    b.HasKey("MaSanPham");

                    b.HasIndex("MaKho");

                    b.ToTable("Sản Phẩm");
                });

            modelBuilder.Entity("Razor.model.HoaDon", b =>
                {
                    b.HasOne("Razor.model.NhanVien", "nhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaNhanVienBan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Razor.model.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("NguoiMua")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("nhanVien");
                });

            modelBuilder.Entity("Razor.model.NhanVien", b =>
                {
                    b.HasOne("Razor.model.NhanVien", null)
                        .WithMany("nhanViens")
                        .HasForeignKey("NhanVienMaNV");
                });

            modelBuilder.Entity("Razor.model.Product", b =>
                {
                    b.HasOne("Razor.model.Kho", "kho")
                        .WithMany("Products")
                        .HasForeignKey("MaKho")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kho");
                });

            modelBuilder.Entity("Razor.model.KhachHang", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("Razor.model.Kho", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Razor.model.NhanVien", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("nhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
