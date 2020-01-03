﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelefonRehberi.Data.Concrete.EfCore;

namespace TelefonRehberi.WebUI.Migrations
{
    [DbContext(typeof(TelefonRehberiContext))]
    [Migration("20200103165630_AdminCreate")]
    partial class AdminCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TelefonRehberi.Entity.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("TelefonRehberi.Entity.Calisan", b =>
                {
                    b.Property<int>("CalisanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CalisanAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CalisanSoyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmanId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YoneticiId")
                        .HasColumnType("int");

                    b.HasKey("CalisanId");

                    b.HasIndex("DepartmanId");

                    b.ToTable("Calisanlar");
                });

            modelBuilder.Entity("TelefonRehberi.Entity.Departman", b =>
                {
                    b.Property<int>("DepartmanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmanAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmanId");

                    b.ToTable("Departmanlar");
                });

            modelBuilder.Entity("TelefonRehberi.Entity.Calisan", b =>
                {
                    b.HasOne("TelefonRehberi.Entity.Departman", "Departman")
                        .WithMany("Calisanlar")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
