﻿// <auto-generated />
using System;
using Esthetic.DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Esthetic.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220608172514_deneme")]
    partial class deneme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Esthetic.Domain.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("UserId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("Esthetic.Domain.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branch", (string)null);
                });

            modelBuilder.Entity("Esthetic.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("Esthetic.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("City", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "06",
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6749),
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6749),
                            Name = "Ankara",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            Code = "34",
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6751),
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6751),
                            Name = "İstanbul",
                            State = 1
                        });
                });

            modelBuilder.Entity("Esthetic.Domain.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LogoUrl")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Company", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6566),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/akl.png",
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6582),
                            Name = "Akl Poliklinik",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6586),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/medeks.png",
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6587),
                            Name = "Medeks Hair Center",
                            State = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6588),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/asuman.png",
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6589),
                            Name = "Asuman Hair Transplant Clinic",
                            State = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6590),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/esteworld.png",
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6590),
                            Name = "Esteworld",
                            State = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6591),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/maya.png",
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6592),
                            Name = "Maya Estetik",
                            State = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6593),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/esteplace.png",
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6593),
                            Name = "Este Place",
                            State = 1
                        });
                });

            modelBuilder.Entity("Esthetic.Domain.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("District", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 2,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6766),
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6767),
                            Name = "Üsküdar",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6768),
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6769),
                            Name = "Kadıköy",
                            State = 1
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            CreatedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6770),
                            ModifiedDate = new DateTime(2022, 6, 8, 20, 25, 13, 980, DateTimeKind.Local).AddTicks(6771),
                            Name = "Ataşehir",
                            State = 1
                        });
                });

            modelBuilder.Entity("Esthetic.Domain.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ImageCategoryType")
                        .HasColumnType("int");

                    b.Property<int>("ImageType")
                        .HasColumnType("int");

                    b.Property<int>("ImageTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("Esthetic.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Esthetic.Domain.Address", b =>
                {
                    b.HasOne("Esthetic.Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Esthetic.Domain.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Esthetic.Domain.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("District");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Esthetic.Domain.Branch", b =>
                {
                    b.HasOne("Esthetic.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Esthetic.Domain.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Address");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Esthetic.Domain.District", b =>
                {
                    b.HasOne("Esthetic.Domain.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Esthetic.Domain.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Esthetic.Domain.Company", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("Esthetic.Domain.User", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
