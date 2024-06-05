using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class delete_table_shoeDetailsSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoesDetails_Sizes");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("1e0c2235-6e08-4238-b4a8-505749401ee5"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("4b089d39-6afb-45b5-8b69-6af236445982"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("b8c686fc-f0ae-4a29-8337-59e386cfab60"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("be751ea0-0f53-437c-93e3-94f461722616"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("cd1215ff-bdef-4e39-9b4a-f2f3e0064331"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("1a160a62-f2f4-4340-ab0c-d60372eef8d8"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("35d840b7-0580-4f48-aa04-1c763476c8d4"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("563e7a02-8c18-4a78-9eb4-42564453e769"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("d40d5061-d782-4f64-b8d0-775a2eeb5203"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("df4959f4-e46e-4560-824d-31a2e5d7d385"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("0580cf7f-67df-4e06-a4b4-ca77e1834b1a"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("0937f48d-9b2d-4511-a1fe-a670df47d38f"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("257b1658-c583-477d-9b2d-dd618348cccd"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("27b21707-05be-425b-811d-be76c926125b"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("35939d62-e7c0-4198-bd71-877f37ca89b1"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("37204af0-2f8b-4167-8f5b-e75898bce3e1"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("578420dd-9849-47ca-b057-11ded00a789b"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("692470fd-5bb9-4354-a8df-f0b370aa707b"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("79b9aac7-6de2-4c72-8353-362da8d1278d"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("968ce8bf-0d67-4067-bf52-e5b04fa34c3b"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("a73b5ce3-bc51-439a-894e-da16abc713a4"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("b3ea9f60-346c-4003-a29c-b7d9456af597"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("c48c70f1-d246-4d12-8bbd-0a621ebe08e8"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("d103bfbb-dd91-4d92-8f7e-2b567c64262f"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("f4043d68-cd40-4d76-96ce-28ff9ff22e63"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("1b3345a5-f9d0-4994-9391-75c8e1b0135d"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("72ef1614-f324-4a13-a3c5-a2b4fdd07b63"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("8a48d7ed-df59-4bf5-ac94-cbc785b646f5"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("cf04a1b7-51b6-4c3c-939f-9a02b152c2d2"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("ff5f0a86-c4fb-47c2-8094-37dde445e93a"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("06f59fd5-1123-428f-8d65-17b7982a3255"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("0ee121c0-84b4-40fa-a297-23452f6602a8"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("16bf64cf-7814-4dfb-90f5-c99c599f873a"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("4874cb76-3875-462d-bcba-ee298790cd12"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("fe46e624-b0e6-481b-a8b5-3361bf565ac6"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("151db43b-1b16-42d3-9bbc-7df09f6f7bb6"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("66f3defb-f75c-4495-9054-ca51376a24a4"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("82e71c2d-8f10-4f7a-8bc8-d400638946ea"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("8fb14508-d80e-411c-9a65-c2a34a47757e"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("c06fe51c-3286-4bd0-aa7f-230b38fcf3dc"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("03731fe6-1f33-4190-9706-00d66b343c3e"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("143a440a-14cd-440d-9940-313cb08c1765"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("7549d945-06c1-44e1-9fd9-009df7d4d81b"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("9900e677-eba1-4e94-9325-e2fc47fb3646"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("de60ebaf-4dfd-48f8-829c-224d5494eb19"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("1b9db785-018c-4db2-9fe6-e6ffc032af75"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("58209b20-61b5-48f6-a580-24d6a501c09c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("5c205a73-0505-4ae8-8397-d62d5388f8cb"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("e3f1ecc4-c80d-4e28-ad6b-d2c35d4b1446"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("ef466da0-5364-41b7-a9ad-99f5b4f66abd"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("1fd2b24d-e41f-47a3-bcbd-8a8e84566b4f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("2102dc38-86a0-4304-958b-f060d553fb1f"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("5ff4c3c2-38e4-42af-86ac-bd40bf99af11"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("ce5ab5fc-0d26-47fd-b149-a03e6a504772"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("da344fab-99ba-4fca-8b7b-0a08b5f71770"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("290ad551-b4f3-40a8-b98e-009b83a2b98e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("35efaa4b-4c57-441a-b6b1-06010cc7dbd6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("6049ea20-2342-4932-a486-56d902ce8933"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("868c7f27-cea0-47f3-88ec-a54e683468d8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("cb140f0e-ab7d-4333-b3bb-3161162617e4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("2b06fe95-4032-44e0-93e3-3310e0a7596d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("37315b88-fc43-4cf8-ada9-03988a1d84bb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("acf34b5d-d435-40d1-a119-b53034fdd4ac"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("cefe6724-b3d9-4db2-9caf-d74d7a5c434a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("fc663b04-a869-4a29-800c-e1dd0ca849ea"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("0e3ab3fc-4aa6-4e64-8aa0-fda128e4aca6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("35afc63c-456d-4456-865d-c4b1ec9b982c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("5239fcbe-5162-44c9-a467-0627a1d145e5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("9eef0615-97b7-4fbe-8d19-14f7f3f9b946"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("c3875613-4f6b-415e-aaf3-7216d04eb7dc"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("0dbab80b-bf2e-47eb-9c45-8a8a7f4eb527"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("387b8741-c25e-4b1d-ab1e-2c885c4ca0c3"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("666215ec-2ec1-4220-98d9-e01c693b4137"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("aa369c90-f3ed-479b-b1bd-77082dd3ab1a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("c0052c43-e369-46e5-9fc7-2f95cd573cd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("108ca0af-5df7-4236-8858-38c3f7e6b385"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("42e5ad39-21a1-4950-ac43-2b979cd7d210"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("5adf4aa0-5810-40ea-80b5-533bf0e532f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("6fa047f4-51f1-4d53-b9cd-3e665a23fe55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("c1e19990-1dc9-4b7d-aac7-1eff0c1fa4f9"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("1d6d14ce-e882-44cc-b662-9c2aa7d541b5"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("27c2138c-4bc7-4be3-bbba-bfa585238757"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("490d16d6-73b8-48ca-aacc-0d5935e4a58f"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("4af1b393-50b1-45d2-85f9-c9bcba777f36"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("d267ff42-a8cc-44d9-ad29-284cc7b5b3a2"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("44adb848-ee4c-472a-afe8-f60f5ce479b0"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("5a542352-5e49-45b7-81bd-414afad23efc"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("d2491469-55db-4736-bca9-a556942839e2"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("fd4f6c06-defc-46f6-b1ee-34c028effb9d"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("fe9ec233-fdc8-4c9b-a099-d42cf179eb43"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("257c60d0-68a2-4847-b272-95877f78d51e"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("3f0a9db1-b329-480d-9761-8755f373f2a4"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("5bfbb201-4ad9-45fe-b589-146ba6c936f9"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("72242a66-8df2-4a44-a744-845032308c04"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("8a4976cc-33df-4f09-bb85-6996196584a8"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("3046ae4a-4010-4f85-870d-d77ab5a9bb23"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("70b24ab2-a09a-4fd5-8ac2-38afdba3ea6c"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("abad49f9-7044-4f60-baff-004c53521fb7"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("ba71900c-8c7c-4f36-b4d7-b58b791acc99"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("d29f9892-5580-4b13-aa4b-b4511739a13a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("0e3a17b7-fb08-4030-9400-c8aa384e1911"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("5d8ef21d-c732-4920-9cfa-22a1289b3bb9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("92b357de-e84a-4961-b62e-5df1fef5d481"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("d7adfbee-5be4-4093-9541-c490a98e3547"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("db21b95e-e57b-44c9-a75d-cc64b7f6a15b"));

            migrationBuilder.AddColumn<Guid>(
                name: "SizeID",
                table: "ShoesDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_SizeID",
                table: "ShoesDetails",
                column: "SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesDetails_Sizes_SizeID",
                table: "ShoesDetails",
                column: "SizeID",
                principalTable: "Sizes",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoesDetails_Sizes_SizeID",
                table: "ShoesDetails");

            migrationBuilder.DropIndex(
                name: "IX_ShoesDetails_SizeID",
                table: "ShoesDetails");

            migrationBuilder.DropColumn(
                name: "SizeID",
                table: "ShoesDetails");

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

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "ColorCode", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("1fd2b24d-e41f-47a3-bcbd-8a8e84566b4f"), "C3", new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5691), "Green", "Active" },
                    { new Guid("2102dc38-86a0-4304-958b-f060d553fb1f"), "C1", new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5684), "Red", "Active" },
                    { new Guid("5ff4c3c2-38e4-42af-86ac-bd40bf99af11"), "C5", new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5693), "Black", "Active" },
                    { new Guid("ce5ab5fc-0d26-47fd-b149-a03e6a504772"), "C4", new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5692), "Yellow", "Active" },
                    { new Guid("da344fab-99ba-4fca-8b7b-0a08b5f71770"), "C2", new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5689), "Blue", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "DateCreated", "Email", "FullName", "Password", "PhoneNumber", "ResetPassword", "Sex", "UserName" },
                values: new object[,]
                {
                    { new Guid("290ad551-b4f3-40a8-b98e-009b83a2b98e"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5142), "customer3@example.com", "Customer 3", "password", "1231231234", "reset3", "Male", "customer3" },
                    { new Guid("35efaa4b-4c57-441a-b6b1-06010cc7dbd6"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5146), "customer5@example.com", "Customer 5", "password", "6789678967", "reset5", "Male", "customer5" },
                    { new Guid("6049ea20-2342-4932-a486-56d902ce8933"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5125), "customer2@example.com", "Customer 2", "password", "0987654321", "reset2", "Female", "customer2" },
                    { new Guid("868c7f27-cea0-47f3-88ec-a54e683468d8"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5144), "customer4@example.com", "Customer 4", "password", "4321432143", "reset4", "Female", "customer4" },
                    { new Guid("cb140f0e-ab7d-4333-b3bb-3161162617e4"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5120), "customer1@example.com", "Customer 1", "password", "1234567890", "reset1", "Male", "customer1" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageID", "DateCreated", "ImageCode", "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0e3ab3fc-4aa6-4e64-8aa0-fda128e4aca6"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5833), "IMG3", "https://example.com/img3_1.jpg", "https://example.com/img3_2.jpg", "https://example.com/img3_3.jpg", "https://example.com/img3_4.jpg", "Image 3", "Active" },
                    { new Guid("35afc63c-456d-4456-865d-c4b1ec9b982c"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5830), "IMG2", "https://example.com/img2_1.jpg", "https://example.com/img2_2.jpg", "https://example.com/img2_3.jpg", "https://example.com/img2_4.jpg", "Image 2", "Active" },
                    { new Guid("5239fcbe-5162-44c9-a467-0627a1d145e5"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5835), "IMG4", "https://example.com/img4_1.jpg", "https://example.com/img4_2.jpg", "https://example.com/img4_3.jpg", "https://example.com/img4_4.jpg", "Image 4", "Active" },
                    { new Guid("9eef0615-97b7-4fbe-8d19-14f7f3f9b946"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5837), "IMG5", "https://example.com/img5_1.jpg", "https://example.com/img5_2.jpg", "https://example.com/img5_3.jpg", "https://example.com/img5_4.jpg", "Image 5", "Active" },
                    { new Guid("c3875613-4f6b-415e-aaf3-7216d04eb7dc"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5826), "IMG1", "https://example.com/img1_1.jpg", "https://example.com/img1_2.jpg", "https://example.com/img1_3.jpg", "https://example.com/img1_4.jpg", "Image 1", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialID", "DateCreated", "MaterialCode", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0dbab80b-bf2e-47eb-9c45-8a8a7f4eb527"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5773), "M2", "Suede", "Active" },
                    { new Guid("387b8741-c25e-4b1d-ab1e-2c885c4ca0c3"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5779), "M5", "Rubber", "Active" },
                    { new Guid("666215ec-2ec1-4220-98d9-e01c693b4137"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5776), "M4", "Synthetic", "Active" },
                    { new Guid("aa369c90-f3ed-479b-b1bd-77082dd3ab1a"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5774), "M3", "Canvas", "Active" },
                    { new Guid("c0052c43-e369-46e5-9fc7-2f95cd573cd1"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5770), "M1", "Leather", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "DateCreated", "Name", "ProductCode", "Status" },
                values: new object[,]
                {
                    { new Guid("108ca0af-5df7-4236-8858-38c3f7e6b385"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5807), "Formal Shoes", "P5", "Active" },
                    { new Guid("42e5ad39-21a1-4950-ac43-2b979cd7d210"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5805), "Boots", "P3", "Active" },
                    { new Guid("5adf4aa0-5810-40ea-80b5-533bf0e532f5"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5806), "Sandals", "P4", "Active" },
                    { new Guid("6fa047f4-51f1-4d53-b9cd-3e665a23fe55"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5803), "Sneakers", "P2", "Active" },
                    { new Guid("c1e19990-1dc9-4b7d-aac7-1eff0c1fa4f9"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5801), "Running Shoes", "P1", "Active" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseMethods",
                columns: new[] { "PurchaseMethodID", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("1d6d14ce-e882-44cc-b662-9c2aa7d541b5"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5486), "Cash", "Active" },
                    { new Guid("27c2138c-4bc7-4be3-bbba-bfa585238757"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5485), "PayPal", "Active" },
                    { new Guid("490d16d6-73b8-48ca-aacc-0d5935e4a58f"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5480), "Credit Card", "Active" },
                    { new Guid("4af1b393-50b1-45d2-85f9-c9bcba777f36"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5487), "Bank Transfer", "Active" },
                    { new Guid("d267ff42-a8cc-44d9-ad29-284cc7b5b3a2"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5489), "Cryptocurrency", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "DateCreated", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("0e3a17b7-fb08-4030-9400-c8aa384e1911"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5330), "R4", "Support" },
                    { new Guid("5d8ef21d-c732-4920-9cfa-22a1289b3bb9"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5328), "R2", "User" },
                    { new Guid("92b357de-e84a-4961-b62e-5df1fef5d481"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5325), "R1", "Admin" },
                    { new Guid("d7adfbee-5be4-4093-9541-c490a98e3547"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5329), "R3", "Manager" },
                    { new Guid("db21b95e-e57b-44c9-a75d-cc64b7f6a15b"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5332), "R5", "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Sexes",
                columns: new[] { "SexID", "SexName" },
                values: new object[,]
                {
                    { new Guid("44adb848-ee4c-472a-afe8-f60f5ce479b0"), "Unisex" },
                    { new Guid("5a542352-5e49-45b7-81bd-414afad23efc"), "Male" },
                    { new Guid("d2491469-55db-4736-bca9-a556942839e2"), "Kids" },
                    { new Guid("fd4f6c06-defc-46f6-b1ee-34c028effb9d"), "Female" },
                    { new Guid("fe9ec233-fdc8-4c9b-a099-d42cf179eb43"), "Others" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("1b9db785-018c-4db2-9fe6-e6ffc032af75"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5657), "Size 1", "S1", "Active" },
                    { new Guid("58209b20-61b5-48f6-a580-24d6a501c09c"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5660), "Size 2", "S2", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("5c205a73-0505-4ae8-8397-d62d5388f8cb"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5662), "Size 4", "S4", "Active" },
                    { new Guid("e3f1ecc4-c80d-4e28-ad6b-d2c35d4b1446"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5661), "Size 3", "S3", "Active" },
                    { new Guid("ef466da0-5364-41b7-a9ad-99f5b4f66abd"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5664), "Size 5", "S5", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "StyleID", "DateCreated", "Name", "Status", "StyleCode" },
                values: new object[,]
                {
                    { new Guid("257c60d0-68a2-4847-b272-95877f78d51e"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5889), "Formal", "Active", "ST3" },
                    { new Guid("3f0a9db1-b329-480d-9761-8755f373f2a4"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5885), "Casual", "Active", "ST1" },
                    { new Guid("5bfbb201-4ad9-45fe-b589-146ba6c936f9"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5892), "Work", "Active", "ST5" },
                    { new Guid("72242a66-8df2-4a44-a744-845032308c04"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5888), "Sport", "Active", "ST2" },
                    { new Guid("8a4976cc-33df-4f09-bb85-6996196584a8"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5891), "Outdoor", "Active", "ST4" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherID", "DateCreated", "ExpirationDate", "MaxUsage", "RemainingUsage", "Status", "Total", "VoucherCode", "VoucherValue" },
                values: new object[,]
                {
                    { new Guid("3046ae4a-4010-4f85-870d-d77ab5a9bb23"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5400), new DateTime(2024, 6, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5400), 10m, 3m, true, 1000, "VC3", 300m },
                    { new Guid("70b24ab2-a09a-4fd5-8ac2-38afdba3ea6c"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5403), new DateTime(2024, 6, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5404), 10m, 2m, true, 1000, "VC4", 400m },
                    { new Guid("abad49f9-7044-4f60-baff-004c53521fb7"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5447), new DateTime(2024, 6, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5448), 10m, 1m, true, 1000, "VC5", 500m },
                    { new Guid("ba71900c-8c7c-4f36-b4d7-b58b791acc99"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5397), new DateTime(2024, 6, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5397), 10m, 4m, true, 1000, "VC2", 200m },
                    { new Guid("d29f9892-5580-4b13-aa4b-b4511739a13a"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5386), new DateTime(2024, 6, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5386), 10m, 5m, true, 1000, "VC1", 100m }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "Commune", "CustomerID", "DateCreated", "District", "DistrictCode", "IsDefaultAddress", "Province", "ShippingCost", "Status", "Street", "WardCode" },
                values: new object[,]
                {
                    { new Guid("1e0c2235-6e08-4238-b4a8-505749401ee5"), "Commune 1", new Guid("cb140f0e-ab7d-4333-b3bb-3161162617e4"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5272), "District 1", "D1", true, "Province 1", 10m, "Active", "Street 1", "W1" },
                    { new Guid("4b089d39-6afb-45b5-8b69-6af236445982"), "Commune 4", new Guid("868c7f27-cea0-47f3-88ec-a54e683468d8"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5288), "District 4", "D4", false, "Province 4", 40m, "Active", "Street 4", "W4" },
                    { new Guid("b8c686fc-f0ae-4a29-8337-59e386cfab60"), "Commune 3", new Guid("290ad551-b4f3-40a8-b98e-009b83a2b98e"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5284), "District 3", "D3", true, "Province 3", 30m, "Active", "Street 3", "W3" },
                    { new Guid("be751ea0-0f53-437c-93e3-94f461722616"), "Commune 5", new Guid("35efaa4b-4c57-441a-b6b1-06010cc7dbd6"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5290), "District 5", "D5", true, "Province 5", 50m, "Active", "Street 5", "W5" },
                    { new Guid("cd1215ff-bdef-4e39-9b4a-f2f3e0064331"), "Commune 2", new Guid("6049ea20-2342-4932-a486-56d902ce8933"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5282), "District 2", "D2", false, "Province 2", 20m, "Active", "Street 2", "W2" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "CustomerID" },
                values: new object[,]
                {
                    { new Guid("151db43b-1b16-42d3-9bbc-7df09f6f7bb6"), new Guid("cb140f0e-ab7d-4333-b3bb-3161162617e4") },
                    { new Guid("66f3defb-f75c-4495-9054-ca51376a24a4"), new Guid("868c7f27-cea0-47f3-88ec-a54e683468d8") },
                    { new Guid("82e71c2d-8f10-4f7a-8bc8-d400638946ea"), new Guid("290ad551-b4f3-40a8-b98e-009b83a2b98e") },
                    { new Guid("8fb14508-d80e-411c-9a65-c2a34a47757e"), new Guid("35efaa4b-4c57-441a-b6b1-06010cc7dbd6") },
                    { new Guid("c06fe51c-3286-4bd0-aa7f-230b38fcf3dc"), new Guid("6049ea20-2342-4932-a486-56d902ce8933") }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateCreated", "Email", "FullName", "IdentificationCode", "Image", "Password", "PhoneNumber", "RoleID", "Sex", "Status", "UserName" },
                values: new object[,]
                {
                    { new Guid("2b06fe95-4032-44e0-93e3-3310e0a7596d"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5351), "employee1@example.com", "Employee 1", "ID1", "img1.png", "password", "1234567890", new Guid("92b357de-e84a-4961-b62e-5df1fef5d481"), "Male", "Active", "employee1" },
                    { new Guid("37315b88-fc43-4cf8-ada9-03988a1d84bb"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5363), "employee4@example.com", "Employee 4", "ID4", "img4.png", "password", "4321432143", new Guid("0e3a17b7-fb08-4030-9400-c8aa384e1911"), "Female", "Active", "employee4" },
                    { new Guid("acf34b5d-d435-40d1-a119-b53034fdd4ac"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5355), "employee2@example.com", "Employee 2", "ID2", "img2.png", "password", "0987654321", new Guid("5d8ef21d-c732-4920-9cfa-22a1289b3bb9"), "Female", "Active", "employee2" },
                    { new Guid("cefe6724-b3d9-4db2-9caf-d74d7a5c434a"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5358), "employee3@example.com", "Employee 3", "ID3", "img3.png", "password", "1231231234", new Guid("d7adfbee-5be4-4093-9541-c490a98e3547"), "Male", "Active", "employee3" },
                    { new Guid("fc663b04-a869-4a29-800c-e1dd0ca849ea"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5365), "employee5@example.com", "Employee 5", "ID5", "img5.png", "password", "6789678967", new Guid("db21b95e-e57b-44c9-a75d-cc64b7f6a15b"), "Male", "Active", "employee5" }
                });

            migrationBuilder.InsertData(
                table: "ShoesDetails",
                columns: new[] { "ShoesDetailsID", "ColorID", "Description", "ImageID", "ImportPrice", "MaterialID", "Price", "ProductID", "SexID", "ShoesDetailsCode", "Status", "StyleID" },
                values: new object[,]
                {
                    { new Guid("03731fe6-1f33-4190-9706-00d66b343c3e"), new Guid("da344fab-99ba-4fca-8b7b-0a08b5f71770"), "Sneakers", new Guid("35afc63c-456d-4456-865d-c4b1ec9b982c"), 1600m, new Guid("0dbab80b-bf2e-47eb-9c45-8a8a7f4eb527"), 2000m, new Guid("6fa047f4-51f1-4d53-b9cd-3e665a23fe55"), new Guid("fd4f6c06-defc-46f6-b1ee-34c028effb9d"), "SD2", "Active", new Guid("72242a66-8df2-4a44-a744-845032308c04") },
                    { new Guid("143a440a-14cd-440d-9940-313cb08c1765"), new Guid("ce5ab5fc-0d26-47fd-b149-a03e6a504772"), "Sandals", new Guid("5239fcbe-5162-44c9-a467-0627a1d145e5"), 3200m, new Guid("666215ec-2ec1-4220-98d9-e01c693b4137"), 4000m, new Guid("5adf4aa0-5810-40ea-80b5-533bf0e532f5"), new Guid("d2491469-55db-4736-bca9-a556942839e2"), "SD4", "Active", new Guid("8a4976cc-33df-4f09-bb85-6996196584a8") },
                    { new Guid("7549d945-06c1-44e1-9fd9-009df7d4d81b"), new Guid("2102dc38-86a0-4304-958b-f060d553fb1f"), "Running Shoes", new Guid("c3875613-4f6b-415e-aaf3-7216d04eb7dc"), 800m, new Guid("c0052c43-e369-46e5-9fc7-2f95cd573cd1"), 1000m, new Guid("c1e19990-1dc9-4b7d-aac7-1eff0c1fa4f9"), new Guid("5a542352-5e49-45b7-81bd-414afad23efc"), "SD1", "Active", new Guid("3f0a9db1-b329-480d-9761-8755f373f2a4") },
                    { new Guid("9900e677-eba1-4e94-9325-e2fc47fb3646"), new Guid("1fd2b24d-e41f-47a3-bcbd-8a8e84566b4f"), "Boots", new Guid("0e3ab3fc-4aa6-4e64-8aa0-fda128e4aca6"), 2400m, new Guid("aa369c90-f3ed-479b-b1bd-77082dd3ab1a"), 3000m, new Guid("42e5ad39-21a1-4950-ac43-2b979cd7d210"), new Guid("44adb848-ee4c-472a-afe8-f60f5ce479b0"), "SD3", "Active", new Guid("257c60d0-68a2-4847-b272-95877f78d51e") },
                    { new Guid("de60ebaf-4dfd-48f8-829c-224d5494eb19"), new Guid("5ff4c3c2-38e4-42af-86ac-bd40bf99af11"), "Formal Shoes", new Guid("9eef0615-97b7-4fbe-8d19-14f7f3f9b946"), 4000m, new Guid("387b8741-c25e-4b1d-ab1e-2c885c4ca0c3"), 5000m, new Guid("108ca0af-5df7-4236-8858-38c3f7e6b385"), new Guid("fe9ec233-fdc8-4c9b-a099-d42cf179eb43"), "SD5", "Active", new Guid("5bfbb201-4ad9-45fe-b589-146ba6c936f9") }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "ID", "BillCode", "CancelDate", "ConfirmationDate", "CustomerID", "DateCreated", "DeliveryDate", "EmployeeID", "IsPaid", "Note", "PaymentDay", "PurchaseMethodID", "ShippingCosts", "Status", "SuccessDate", "TotalPrice", "TotalPriceAfterDiscount", "TransactionType", "UpdateDate", "VoucherID" },
                values: new object[,]
                {
                    { new Guid("06f59fd5-1123-428f-8d65-17b7982a3255"), "B3", null, new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5537), new Guid("290ad551-b4f3-40a8-b98e-009b83a2b98e"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5535), new DateTime(2024, 6, 1, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5535), new Guid("cefe6724-b3d9-4db2-9caf-d74d7a5c434a"), true, "Note 3", new DateTime(2024, 5, 30, 10, 42, 27, 534, DateTimeKind.Utc).AddTicks(5537), new Guid("1d6d14ce-e882-44cc-b662-9c2aa7d541b5"), 150m, "Delivered", new DateTime(2024, 5, 31, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5535), 3000m, 2850m, "Credit", new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5537), new Guid("3046ae4a-4010-4f85-870d-d77ab5a9bb23") },
                    { new Guid("0ee121c0-84b4-40fa-a297-23452f6602a8"), "B2", null, new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5530), new Guid("6049ea20-2342-4932-a486-56d902ce8933"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5528), new DateTime(2024, 6, 1, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5529), new Guid("acf34b5d-d435-40d1-a119-b53034fdd4ac"), true, "Note 2", new DateTime(2024, 5, 30, 10, 42, 27, 534, DateTimeKind.Utc).AddTicks(5531), new Guid("27c2138c-4bc7-4be3-bbba-bfa585238757"), 100m, "Delivered", new DateTime(2024, 5, 31, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5529), 2000m, 1900m, "Credit", new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5531), new Guid("ba71900c-8c7c-4f36-b4d7-b58b791acc99") },
                    { new Guid("16bf64cf-7814-4dfb-90f5-c99c599f873a"), "B1", null, new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5520), new Guid("cb140f0e-ab7d-4333-b3bb-3161162617e4"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5511), new DateTime(2024, 6, 1, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5517), new Guid("2b06fe95-4032-44e0-93e3-3310e0a7596d"), true, "Note 1", new DateTime(2024, 5, 30, 10, 42, 27, 534, DateTimeKind.Utc).AddTicks(5522), new Guid("490d16d6-73b8-48ca-aacc-0d5935e4a58f"), 50m, "Delivered", new DateTime(2024, 5, 31, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5512), 1000m, 950m, "Credit", new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5521), new Guid("d29f9892-5580-4b13-aa4b-b4511739a13a") },
                    { new Guid("4874cb76-3875-462d-bcba-ee298790cd12"), "B5", null, new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5549), new Guid("35efaa4b-4c57-441a-b6b1-06010cc7dbd6"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5548), new DateTime(2024, 6, 1, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5549), new Guid("fc663b04-a869-4a29-800c-e1dd0ca849ea"), true, "Note 5", new DateTime(2024, 5, 30, 10, 42, 27, 534, DateTimeKind.Utc).AddTicks(5550), new Guid("d267ff42-a8cc-44d9-ad29-284cc7b5b3a2"), 250m, "Delivered", new DateTime(2024, 5, 31, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5548), 5000m, 4750m, "Credit", new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5550), new Guid("abad49f9-7044-4f60-baff-004c53521fb7") },
                    { new Guid("fe46e624-b0e6-481b-a8b5-3361bf565ac6"), "B4", null, new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5542), new Guid("868c7f27-cea0-47f3-88ec-a54e683468d8"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 6, 1, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5541), new Guid("37315b88-fc43-4cf8-ada9-03988a1d84bb"), true, "Note 4", new DateTime(2024, 5, 30, 10, 42, 27, 534, DateTimeKind.Utc).AddTicks(5543), new Guid("4af1b393-50b1-45d2-85f9-c9bcba777f36"), 200m, "Delivered", new DateTime(2024, 5, 31, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5540), 4000m, 3800m, "Credit", new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5543), new Guid("70b24ab2-a09a-4fd5-8ac2-38afdba3ea6c") }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "ID", "CartID", "Quantity", "ShoeDetailsID" },
                values: new object[,]
                {
                    { new Guid("1b3345a5-f9d0-4994-9391-75c8e1b0135d"), new Guid("151db43b-1b16-42d3-9bbc-7df09f6f7bb6"), 1, new Guid("7549d945-06c1-44e1-9fd9-009df7d4d81b") },
                    { new Guid("72ef1614-f324-4a13-a3c5-a2b4fdd07b63"), new Guid("8fb14508-d80e-411c-9a65-c2a34a47757e"), 5, new Guid("de60ebaf-4dfd-48f8-829c-224d5494eb19") },
                    { new Guid("8a48d7ed-df59-4bf5-ac94-cbc785b646f5"), new Guid("66f3defb-f75c-4495-9054-ca51376a24a4"), 4, new Guid("143a440a-14cd-440d-9940-313cb08c1765") },
                    { new Guid("cf04a1b7-51b6-4c3c-939f-9a02b152c2d2"), new Guid("c06fe51c-3286-4bd0-aa7f-230b38fcf3dc"), 2, new Guid("03731fe6-1f33-4190-9706-00d66b343c3e") },
                    { new Guid("ff5f0a86-c4fb-47c2-8094-37dde445e93a"), new Guid("82e71c2d-8f10-4f7a-8bc8-d400638946ea"), 3, new Guid("9900e677-eba1-4e94-9325-e2fc47fb3646") }
                });

            migrationBuilder.InsertData(
                table: "ShoesDetails_Sizes",
                columns: new[] { "ID", "Quantity", "ShoesDetailsID", "SizeID" },
                values: new object[,]
                {
                    { new Guid("20659f4b-4e3f-46d0-b821-9b16e9e2e427"), 30, new Guid("9900e677-eba1-4e94-9325-e2fc47fb3646"), new Guid("e3f1ecc4-c80d-4e28-ad6b-d2c35d4b1446") },
                    { new Guid("5ed45046-8532-4312-a902-b4afcbe9f4c1"), 20, new Guid("03731fe6-1f33-4190-9706-00d66b343c3e"), new Guid("58209b20-61b5-48f6-a580-24d6a501c09c") },
                    { new Guid("6865902a-2727-410f-9a86-64a36ab2d85b"), 50, new Guid("de60ebaf-4dfd-48f8-829c-224d5494eb19"), new Guid("ef466da0-5364-41b7-a9ad-99f5b4f66abd") },
                    { new Guid("759ae7df-f8f4-4d00-8e28-3e6949d3d2e9"), 40, new Guid("143a440a-14cd-440d-9940-313cb08c1765"), new Guid("5c205a73-0505-4ae8-8397-d62d5388f8cb") },
                    { new Guid("c5ce4aaf-83ee-4371-b4e2-93b02f1cfaa6"), 10, new Guid("7549d945-06c1-44e1-9fd9-009df7d4d81b"), new Guid("1b9db785-018c-4db2-9fe6-e6ffc032af75") }
                });

            migrationBuilder.InsertData(
                table: "BillDetails",
                columns: new[] { "ID", "BillID", "Price", "Quantity", "ShoesDetails_SizeID", "Status" },
                values: new object[,]
                {
                    { new Guid("1a160a62-f2f4-4340-ab0c-d60372eef8d8"), new Guid("06f59fd5-1123-428f-8d65-17b7982a3255"), 3000m, 3, new Guid("1891c2e8-ab12-452e-9ccb-0436516fdca9"), "Delivered" },
                    { new Guid("35d840b7-0580-4f48-aa04-1c763476c8d4"), new Guid("fe46e624-b0e6-481b-a8b5-3361bf565ac6"), 4000m, 4, new Guid("5f6c1e41-9ec7-44ac-89ee-a2b9fb64add9"), "Delivered" },
                    { new Guid("563e7a02-8c18-4a78-9eb4-42564453e769"), new Guid("16bf64cf-7814-4dfb-90f5-c99c599f873a"), 1000m, 1, new Guid("7890c56d-6b31-4fb6-a0b7-ce78be9e040a"), "Delivered" },
                    { new Guid("d40d5061-d782-4f64-b8d0-775a2eeb5203"), new Guid("0ee121c0-84b4-40fa-a297-23452f6602a8"), 2000m, 2, new Guid("f3657c82-a4ba-4b7d-b868-9b3e14a888ac"), "Delivered" },
                    { new Guid("df4959f4-e46e-4560-824d-31a2e5d7d385"), new Guid("4874cb76-3875-462d-bcba-ee298790cd12"), 5000m, 5, new Guid("cb8e619e-d4ff-4944-b225-323bcc122110"), "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "BillStatusHistories",
                columns: new[] { "BillStatusHistoryID", "BillID", "ChangeDate", "Note", "Status" },
                values: new object[,]
                {
                    { new Guid("0580cf7f-67df-4e06-a4b4-ca77e1834b1a"), new Guid("0ee121c0-84b4-40fa-a297-23452f6602a8"), new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5615), "Order shipped", "Shipped" },
                    { new Guid("0937f48d-9b2d-4511-a1fe-a670df47d38f"), new Guid("06f59fd5-1123-428f-8d65-17b7982a3255"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5621), "Order placed", "Ordered" },
                    { new Guid("257b1658-c583-477d-9b2d-dd618348cccd"), new Guid("fe46e624-b0e6-481b-a8b5-3361bf565ac6"), new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5628), "Order shipped", "Shipped" },
                    { new Guid("27b21707-05be-425b-811d-be76c926125b"), new Guid("16bf64cf-7814-4dfb-90f5-c99c599f873a"), new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5612), "Order delivered", "Delivered" },
                    { new Guid("35939d62-e7c0-4198-bd71-877f37ca89b1"), new Guid("16bf64cf-7814-4dfb-90f5-c99c599f873a"), new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5610), "Order shipped", "Shipped" },
                    { new Guid("37204af0-2f8b-4167-8f5b-e75898bce3e1"), new Guid("0ee121c0-84b4-40fa-a297-23452f6602a8"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5613), "Order placed", "Ordered" },
                    { new Guid("578420dd-9849-47ca-b057-11ded00a789b"), new Guid("06f59fd5-1123-428f-8d65-17b7982a3255"), new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5624), "Order delivered", "Delivered" },
                    { new Guid("692470fd-5bb9-4354-a8df-f0b370aa707b"), new Guid("0ee121c0-84b4-40fa-a297-23452f6602a8"), new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5619), "Order delivered", "Delivered" },
                    { new Guid("79b9aac7-6de2-4c72-8353-362da8d1278d"), new Guid("4874cb76-3875-462d-bcba-ee298790cd12"), new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5635), "Order shipped", "Shipped" },
                    { new Guid("968ce8bf-0d67-4067-bf52-e5b04fa34c3b"), new Guid("16bf64cf-7814-4dfb-90f5-c99c599f873a"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5607), "Order placed", "Ordered" },
                    { new Guid("a73b5ce3-bc51-439a-894e-da16abc713a4"), new Guid("4874cb76-3875-462d-bcba-ee298790cd12"), new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5637), "Order delivered", "Delivered" },
                    { new Guid("b3ea9f60-346c-4003-a29c-b7d9456af597"), new Guid("4874cb76-3875-462d-bcba-ee298790cd12"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5632), "Order placed", "Ordered" },
                    { new Guid("c48c70f1-d246-4d12-8bbd-0a621ebe08e8"), new Guid("fe46e624-b0e6-481b-a8b5-3361bf565ac6"), new DateTime(2024, 5, 30, 9, 42, 27, 534, DateTimeKind.Utc).AddTicks(5630), "Order delivered", "Delivered" },
                    { new Guid("d103bfbb-dd91-4d92-8f7e-2b567c64262f"), new Guid("06f59fd5-1123-428f-8d65-17b7982a3255"), new DateTime(2024, 5, 30, 8, 42, 27, 534, DateTimeKind.Utc).AddTicks(5623), "Order shipped", "Shipped" },
                    { new Guid("f4043d68-cd40-4d76-96ce-28ff9ff22e63"), new Guid("fe46e624-b0e6-481b-a8b5-3361bf565ac6"), new DateTime(2024, 5, 30, 7, 42, 27, 534, DateTimeKind.Utc).AddTicks(5627), "Order placed", "Ordered" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_Sizes_ShoesDetailsID",
                table: "ShoesDetails_Sizes",
                column: "ShoesDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_Sizes_SizeID",
                table: "ShoesDetails_Sizes",
                column: "SizeID");
        }
    }
}
