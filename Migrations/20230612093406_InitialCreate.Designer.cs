﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using spjeniscat.Data;

#nullable disable

namespace spjeniscat.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230612093406_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("spjeniscat.Models.JenisCat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KodeJenis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("JenisCat");
                });

            modelBuilder.Entity("spjeniscat.Models.KondisiRumah", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KodeKondisi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Kondisi")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("KondisiRumah");
                });

            modelBuilder.Entity("spjeniscat.Models.Konsumen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Kontak")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Konsumen");
                });
#pragma warning restore 612, 618
        }
    }
}
