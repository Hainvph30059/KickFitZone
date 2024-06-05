using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class create_database_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResetPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImageUrl1 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageUrl2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageUrl3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageUrl4 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageID);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseMethods",
                columns: table => new
                {
                    PurchaseMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseMethods", x => x.PurchaseMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    SexID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SexName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.SexID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeID);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    StyleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StyleCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.StyleID);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    VoucherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VoucherValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RemainingUsage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxUsage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", maxLength: 20, nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Commune = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDefaultAddress = table.Column<bool>(type: "bit", nullable: false),
                    ShippingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DistrictCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WardCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentificationCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoesDetails",
                columns: table => new
                {
                    ShoesDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoesDetailsCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImportPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ColorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StyleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SexID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoesDetails", x => x.ShoesDetailsID);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ColorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Images_ImageID",
                        column: x => x.ImageID,
                        principalTable: "Images",
                        principalColumn: "ImageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Materials_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Materials",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Sexes_SexID",
                        column: x => x.SexID,
                        principalTable: "Sexes",
                        principalColumn: "SexID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Styles_StyleID",
                        column: x => x.StyleID,
                        principalTable: "Styles",
                        principalColumn: "StyleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuccessDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingCosts = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPriceAfterDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDay = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    VoucherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchaseMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bills_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_Bills_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_PurchaseMethods_PurchaseMethodID",
                        column: x => x.PurchaseMethodID,
                        principalTable: "PurchaseMethods",
                        principalColumn: "PurchaseMethodID");
                    table.ForeignKey(
                        name: "FK_Bills_Vouchers_VoucherID",
                        column: x => x.VoucherID,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherID");
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoeDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_CartID",
                        column: x => x.CartID,
                        principalTable: "Carts",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_ShoesDetails_ShoeDetailsID",
                        column: x => x.ShoeDetailsID,
                        principalTable: "ShoesDetails",
                        principalColumn: "ShoesDetailsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoesDetails_Sizes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoesDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoesDetails_Sizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Sizes_ShoesDetails_ShoesDetailsID",
                        column: x => x.ShoesDetailsID,
                        principalTable: "ShoesDetails",
                        principalColumn: "ShoesDetailsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoesDetails_Sizes_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "SizeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoesDetails_SizeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_BillID",
                        column: x => x.BillID,
                        principalTable: "Bills",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BillStatusHistories",
                columns: table => new
                {
                    BillStatusHistoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillStatusHistories", x => x.BillStatusHistoryID);
                    table.ForeignKey(
                        name: "FK_BillStatusHistories_Bills_BillID",
                        column: x => x.BillID,
                        principalTable: "Bills",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerID",
                table: "Addresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillID",
                table: "BillDetails",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_CustomerID",
                table: "Bills",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_EmployeeID",
                table: "Bills",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PurchaseMethodID",
                table: "Bills",
                column: "PurchaseMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_VoucherID",
                table: "Bills",
                column: "VoucherID");

            migrationBuilder.CreateIndex(
                name: "IX_BillStatusHistories_BillID",
                table: "BillStatusHistories",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_CartID",
                table: "CartDetails",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_ShoeDetailsID",
                table: "CartDetails",
                column: "ShoeDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_CustomerID",
                table: "Carts",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleID",
                table: "Employees",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_ColorID",
                table: "ShoesDetails",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_ImageID",
                table: "ShoesDetails",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_MaterialID",
                table: "ShoesDetails",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_ProductID",
                table: "ShoesDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_SexID",
                table: "ShoesDetails",
                column: "SexID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_StyleID",
                table: "ShoesDetails",
                column: "StyleID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_Sizes_ShoesDetailsID",
                table: "ShoesDetails_Sizes",
                column: "ShoesDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_Sizes_SizeID",
                table: "ShoesDetails_Sizes",
                column: "SizeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "BillStatusHistories");

            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "ShoesDetails_Sizes");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ShoesDetails");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "PurchaseMethods");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
