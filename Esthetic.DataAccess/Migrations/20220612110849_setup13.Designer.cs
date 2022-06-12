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
    [Migration("20220612110849_setup13")]
    partial class setup13
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
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8564),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8565),
                            Name = "Ankara",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            Code = "34",
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8566),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8567),
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
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8171),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/akl.png",
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8368),
                            Name = "Akl Poliklinik",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8372),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/medeks.png",
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8373),
                            Name = "Medeks Hair Center",
                            State = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8374),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/asuman.png",
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8375),
                            Name = "Asuman Hair Transplant Clinic",
                            State = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8376),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/esteworld.png",
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8376),
                            Name = "Esteworld",
                            State = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8377),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/maya.png",
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8378),
                            Name = "Maya Estetik",
                            State = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8379),
                            LogoUrl = "http://ayyildiz.xyz:8070/company/esteplace.png",
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8379),
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
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8582),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8583),
                            Name = "Üsküdar",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8584),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8585),
                            Name = "Kadıköy",
                            State = 1
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8586),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8586),
                            Name = "Ataşehir",
                            State = 1
                        });
                });

            modelBuilder.Entity("Esthetic.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("MediumBlob");

                    b.Property<int>("ImageCategoryType")
                        .HasColumnType("int");

                    b.Property<int>("ImageType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Image", (string)null);
                });

            modelBuilder.Entity("Esthetic.Domain.OperationType", b =>
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

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OperationType", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8534),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8535),
                            Name = "Saç Ekimi",
                            State = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8537),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8537),
                            Name = "Kök Hücre Tedavisi",
                            State = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8538),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8539),
                            Name = "P.R.P",
                            State = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8540),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8540),
                            Name = "Botoks",
                            State = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8541),
                            ModifiedDate = new DateTime(2022, 6, 12, 14, 8, 49, 443, DateTimeKind.Local).AddTicks(8542),
                            Name = "Lazer Epilasyon",
                            State = 1
                        });
                });

            modelBuilder.Entity("Esthetic.Domain.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Post", (string)null);
                });

            modelBuilder.Entity("Esthetic.Domain.PostMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Content")
                        .HasMaxLength(250)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("char(36)");

                    b.Property<int>("MediaType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<Guid?>("VideoId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("PostId");

                    b.HasIndex("VideoId");

                    b.ToTable("PostMedia", (string)null);
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

            modelBuilder.Entity("Esthetic.Domain.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Video");
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

            modelBuilder.Entity("Esthetic.Domain.Post", b =>
                {
                    b.HasOne("Esthetic.Domain.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Esthetic.Domain.PostMedia", b =>
                {
                    b.HasOne("Esthetic.Domain.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Esthetic.Domain.Post", "Post")
                        .WithMany("PostMedias")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Esthetic.Domain.Video", "Video")
                        .WithMany()
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Image");

                    b.Navigation("Post");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("Esthetic.Domain.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("Esthetic.Domain.Company", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("Esthetic.Domain.Post", b =>
                {
                    b.Navigation("PostMedias");
                });

            modelBuilder.Entity("Esthetic.Domain.User", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
