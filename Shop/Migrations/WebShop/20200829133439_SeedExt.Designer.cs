﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.DAL;

namespace Shop.Migrations.WebShop
{
    [DbContext(typeof(WebShopContext))]
    [Migration("20200829133439_SeedExt")]
    partial class SeedExt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "sport category description",
                            Icon = "sport.png",
                            Name = "Sport"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "garden category description",
                            Icon = "garden.png",
                            Name = "Garden"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "automotive category description",
                            Icon = "automotive.png",
                            Name = "Automotive"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "home category description",
                            Icon = "home.png",
                            Name = "Home"
                        },
                        new
                        {
                            CategoryId = 5,
                            Description = "animals category description",
                            Icon = "animals.png",
                            Name = "Animals"
                        });
                });

            modelBuilder.Entity("Shop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(7746),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 2,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9786),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 3,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9832),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 4,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9840),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 5,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9844),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 6,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9852),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 7,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9856),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 8,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9864),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 9,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9868),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 10,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9873),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 11,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9877),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 12,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9885),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 13,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9889),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 14,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9893),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 15,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9897),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        },
                        new
                        {
                            OrderId = 16,
                            Address = "Jaśminowa 5",
                            City = "Warszawa",
                            Comment = "comment",
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 738, DateTimeKind.Local).AddTicks(9901),
                            Email = "janusz@gmail.com",
                            FirstName = "Janusz",
                            LastName = "Kowalski",
                            PostalCode = "20-220",
                            Price = "0,00",
                            State = 0
                        });
                });

            modelBuilder.Entity("Shop.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("TotalPrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Shop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 733, DateTimeKind.Local).AddTicks(6842),
                            Description = "Gloves description",
                            Image = "gloves.png",
                            IsActive = true,
                            Name = "Gloves Everlast XL",
                            Price = "120,99"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8365),
                            Description = "T-shirt description",
                            Image = "t-shirt.png",
                            IsActive = true,
                            Name = "T-shirt Everlast XL",
                            Price = "60,99"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8447),
                            Description = "trousers description",
                            Image = "trousers.png",
                            IsActive = true,
                            Name = "Adidas trousers",
                            Price = "290,99"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8455),
                            Description = "band description",
                            Image = "miband.png",
                            IsActive = true,
                            Name = "Mi Band",
                            Price = "300,00"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8460),
                            Description = "Baseball cap description",
                            Image = "b_cap.png",
                            IsActive = true,
                            Name = "Baseball cap",
                            Price = "299,99"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8468),
                            Description = "Camping tent description",
                            Image = "camping-tent.png",
                            IsActive = true,
                            Name = "Camping tent",
                            Price = "179,99"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8472),
                            Description = "bicycle helmet description",
                            Image = "bike_helmet.png",
                            IsActive = true,
                            Name = "Bicycle helmet",
                            Price = "99,99"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2020, 8, 29, 15, 34, 38, 737, DateTimeKind.Local).AddTicks(8476),
                            Description = "football description",
                            Image = "football.png",
                            IsActive = true,
                            Name = "Football F500 Kipsta",
                            Price = "269,99"
                        });
                });

            modelBuilder.Entity("Shop.Models.OrderItem", b =>
                {
                    b.HasOne("Shop.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Shop.Models.Product", b =>
                {
                    b.HasOne("Shop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
