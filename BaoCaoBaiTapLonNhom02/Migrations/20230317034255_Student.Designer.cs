﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaoCaoBaiTapLonNhom02.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230317034255_Student")]
    partial class Student
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("BaoCaoBaiTapLonNhom02.Models.Nhom", b =>
                {
                    b.Property<string>("MaNhom")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNhom")
                        .HasColumnType("TEXT");

                    b.HasKey("MaNhom");

                    b.ToTable("Nhom");
                });

            modelBuilder.Entity("BaoCaoBaiTapLonNhom02.Models.Student", b =>
                {
                    b.Property<string>("MaID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaNhom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaID");

                    b.HasIndex("MaNhom");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("BaoCaoBaiTapLonNhom02.Models.Student", b =>
                {
                    b.HasOne("BaoCaoBaiTapLonNhom02.Models.Nhom", "Nhom")
                        .WithMany()
                        .HasForeignKey("MaNhom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nhom");
                });
#pragma warning restore 612, 618
        }
    }
}