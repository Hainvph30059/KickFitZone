﻿// <auto-generated />
using System;
using APP_DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APP_DATA.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240605005951_delete_table_shoeDetailsSize")]
    partial class delete_table_shoeDetailsSize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("APP_DATA.Entity.Address", b =>
                {
                    b.Property<Guid>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Commune")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DistrictCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("IsDefaultAddress")
                        .HasColumnType("bit");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("ShippingCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WardCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("AddressID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("APP_DATA.Entity.Bill", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BillCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CancelDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ConfirmationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PaymentDay")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PurchaseMethodID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ShippingCosts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("SuccessDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPriceAfterDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VoucherID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("PurchaseMethodID");

                    b.HasIndex("VoucherID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("APP_DATA.Entity.BillDetails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoesDetails_SizeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BillID");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.BillStatusHistory", b =>
                {
                    b.Property<Guid>("BillStatusHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BillID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillStatusHistoryID");

                    b.HasIndex("BillID");

                    b.ToTable("BillStatusHistories");
                });

            modelBuilder.Entity("APP_DATA.Entity.Cart", b =>
                {
                    b.Property<Guid>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CartID");

                    b.HasIndex("CustomerID")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("APP_DATA.Entity.CartDetails", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CartID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("ShoeDetailsID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CartID");

                    b.HasIndex("ShoeDetailsID");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Color", b =>
                {
                    b.Property<Guid>("ColorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ColorID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("APP_DATA.Entity.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ResetPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("APP_DATA.Entity.Employee", b =>
                {
                    b.Property<Guid>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IdentificationCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("RoleID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("APP_DATA.Entity.Image", b =>
                {
                    b.Property<Guid>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ImageUrl1")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImageUrl2")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImageUrl3")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImageUrl4")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ImageID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("APP_DATA.Entity.Material", b =>
                {
                    b.Property<Guid>("MaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaterialCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("MaterialID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("APP_DATA.Entity.Product", b =>
                {
                    b.Property<Guid>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("APP_DATA.Entity.PurchaseMethod", b =>
                {
                    b.Property<Guid>("PurchaseMethodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PurchaseMethodID");

                    b.ToTable("PurchaseMethods");
                });

            modelBuilder.Entity("APP_DATA.Entity.Role", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("APP_DATA.Entity.Sex", b =>
                {
                    b.Property<Guid>("SexID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SexName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("SexID");

                    b.ToTable("Sexes");
                });

            modelBuilder.Entity("APP_DATA.Entity.ShoesDetails", b =>
                {
                    b.Property<Guid>("ShoesDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ColorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("ImageID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ImportPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("MaterialID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SexID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShoesDetailsCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("SizeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("StyleID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ShoesDetailsID");

                    b.HasIndex("ColorID");

                    b.HasIndex("ImageID");

                    b.HasIndex("MaterialID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SexID");

                    b.HasIndex("SizeID");

                    b.HasIndex("StyleID");

                    b.ToTable("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Size", b =>
                {
                    b.Property<Guid>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SizeCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SizeID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("APP_DATA.Entity.Style", b =>
                {
                    b.Property<Guid>("StyleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("StyleCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("StyleID");

                    b.ToTable("Styles");
                });

            modelBuilder.Entity("APP_DATA.Entity.Voucher", b =>
                {
                    b.Property<Guid>("VoucherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaxUsage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RemainingUsage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("bit");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<string>("VoucherCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("VoucherValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VoucherID");

                    b.ToTable("Vouchers");
                });

            modelBuilder.Entity("APP_DATA.Entity.Address", b =>
                {
                    b.HasOne("APP_DATA.Entity.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("APP_DATA.Entity.Bill", b =>
                {
                    b.HasOne("APP_DATA.Entity.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Employee", "Employee")
                        .WithMany("Bills")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.PurchaseMethod", "PurchaseMethod")
                        .WithMany("Bills")
                        .HasForeignKey("PurchaseMethodID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Voucher", "Voucher")
                        .WithMany("Bills")
                        .HasForeignKey("VoucherID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("PurchaseMethod");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("APP_DATA.Entity.BillDetails", b =>
                {
                    b.HasOne("APP_DATA.Entity.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("APP_DATA.Entity.BillStatusHistory", b =>
                {
                    b.HasOne("APP_DATA.Entity.Bill", "Bill")
                        .WithMany("BillStatusHistories")
                        .HasForeignKey("BillID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("APP_DATA.Entity.Cart", b =>
                {
                    b.HasOne("APP_DATA.Entity.Customer", "Customer")
                        .WithOne("Carts")
                        .HasForeignKey("APP_DATA.Entity.Cart", "CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("APP_DATA.Entity.CartDetails", b =>
                {
                    b.HasOne("APP_DATA.Entity.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.ShoesDetails", "ShoesDetails")
                        .WithMany("CartDetails")
                        .HasForeignKey("ShoeDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Employee", b =>
                {
                    b.HasOne("APP_DATA.Entity.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("APP_DATA.Entity.ShoesDetails", b =>
                {
                    b.HasOne("APP_DATA.Entity.Color", "Color")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Image", "Image")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("ImageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Material", "Material")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Product", "Product")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Sex", "Sex")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("SexID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Size", "Size")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APP_DATA.Entity.Style", "Style")
                        .WithMany("ShoesDetails")
                        .HasForeignKey("StyleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Image");

                    b.Navigation("Material");

                    b.Navigation("Product");

                    b.Navigation("Sex");

                    b.Navigation("Size");

                    b.Navigation("Style");
                });

            modelBuilder.Entity("APP_DATA.Entity.Bill", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("BillStatusHistories");
                });

            modelBuilder.Entity("APP_DATA.Entity.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Color", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Bills");

                    b.Navigation("Carts")
                        .IsRequired();
                });

            modelBuilder.Entity("APP_DATA.Entity.Employee", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("APP_DATA.Entity.Image", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Material", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Product", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.PurchaseMethod", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("APP_DATA.Entity.Role", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("APP_DATA.Entity.Sex", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.ShoesDetails", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Size", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Style", b =>
                {
                    b.Navigation("ShoesDetails");
                });

            modelBuilder.Entity("APP_DATA.Entity.Voucher", b =>
                {
                    b.Navigation("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
