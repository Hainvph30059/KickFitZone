using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class Data_Test_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("0b24739a-76f8-4bf1-a100-97b706c84108"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("6afdf35b-11d9-4a8b-b305-2795fa116a9c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("7ccec7a8-9632-43da-8686-2310883160af"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("f1ba1903-5513-4d0c-9d80-c47619ef43da"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("f830ea6f-b5f0-4f21-b486-bb38184f7afa"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("108832fd-2b54-4592-b287-a15ec79474db"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("39fbfb26-de26-4fe1-a1ad-67ca088a710c"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("4bcff043-25e6-4ab3-8471-dc0fb25ab038"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("9fc42096-9235-4995-aebd-9ca37b46a607"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("e14d4039-81be-4a4d-824b-2bffa6dc7bfc"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("4728fe6d-21bf-44a1-8a31-ef24f1b6b8c6"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("498bed47-7824-42ff-94e8-0311b8eae461"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("4d6d8b91-73d9-48fd-be98-24d18efc271b"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("63ca7a85-6d94-4cb4-9c3b-8b9bcf21ce52"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("65a65e2e-7163-496d-9f2a-1c0f8302b42b"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("89b69b59-9b76-4266-bc34-92882af25891"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("8b69e7fc-cc6f-4f73-8ef1-826aa9ac6994"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("933953e3-4e81-4177-8728-15bc6bacfeef"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("a3a22577-e2c1-439a-ad82-9e0fd6778acc"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("c775dbe5-bf8c-46f3-a3d3-8db5b64baef4"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("cc63b8a9-bf65-4552-9a75-46ec64549b1f"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("d6b59a3e-7b9e-44e6-bb80-24471177e488"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("f0dfc023-fbb8-4b54-a67f-26d1a31242a6"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("fd9c417a-fda3-42e7-b2b8-ee4717acaf25"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("feff2b5b-439e-44c0-8b5c-b0cae46e5fbb"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("94712c23-7d6f-45fc-b780-ac910d58315b"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("cc0158e1-40a8-4053-98ad-953dab7f20cc"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("e56fc914-7b46-4977-b4db-370019daec49"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("ec1ad9f7-f544-46a3-8ff9-9e5602f8aa20"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("f80ae670-00c7-4ba6-8b88-1d91ef8ae2c9"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("2d41d790-a11a-4e9f-bcd9-1fe446d55632"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("350d9f52-717f-413e-8b1a-35d68e6c5703"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("845d90bc-8661-4e3e-8f5d-1c6ad82d564b"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("a9582e25-ac8e-4993-a05c-f52baf655d09"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("c61c9b0c-257f-498e-b68d-dbeefa2cb9c0"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("6cb952f1-16af-49b9-b06c-f2ec3d8c003d"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("80522396-41a9-4191-8da8-2bee8fb1b318"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("8564a625-bb01-43b5-856a-335aaf039ee1"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("d7af55e8-33ba-41c2-bf17-2bb26a249665"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("e5e44eb3-92fc-4b9b-8c6e-23eaee77361b"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("29a027a1-8b3e-473e-825a-ddec6adf3f96"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("4a267411-3750-43de-b466-f0dcbb8fd807"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("7d932b9b-2088-44ce-89fd-8658bf7ef3db"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("a6f29bf2-35be-4983-ae36-41eeee344852"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("c002c7e9-3777-4c9f-98ef-39570dfb10df"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("43c31dbd-d843-4787-9cc4-475b0b06acef"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("44e439a3-e71f-4ade-9ffe-2d14b605f7ec"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("5f644f1c-b75a-43df-a184-4370469dcf04"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("eeb800ef-dc32-4a54-b72a-c8daf9cc7de9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("fe90651c-fb43-4692-91f1-e415d4e0e4c4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("9f0fb17c-dd4a-4938-99b6-e33146aee6ac"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("a35828c1-9f12-4e96-b095-294f3a237d52"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("a83aee0b-c02b-4f24-948d-a0e069d8007d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("db6d4430-1bab-4a99-8410-5cf1f1abe54a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("eec176ba-59b8-4f0b-9c61-bf00cb3458f4"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("371563be-e757-4e15-a91a-103ea9fe4fd2"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("65236c11-a1d5-4c88-983e-8ca95098cd9b"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("7c3ac735-b408-4758-906c-dd6ef74e0c90"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("bd803e52-5fcb-41ba-9a6f-f1e5ba2d6d5b"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("e204da23-bb6e-4167-a173-9f81da978195"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("274b28ab-d6f0-4a56-8dcf-fa7cbe1cb2c8"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("49e886b2-4517-49c9-a22a-0c9468994f61"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("4e934ca4-e7cd-49db-ae2b-d587d786a847"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("e35d9c32-839a-4234-8e57-a7cc3d4bfd63"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("fc4c7431-458d-4dd9-a0ed-493a1cef8a38"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("10c098fc-0c8d-46b4-a91c-ee9858959ae2"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("2d1c4cf3-feb9-429b-abfb-0fb37700194c"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("612836b0-f6c5-4cd5-b141-8c90b638d3c3"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("babcd2bb-4040-4082-8552-2e3af478802b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("d849bd09-0183-4e6e-8ef8-7fe85b06000a"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("09aa254d-74f3-49c2-a38e-84deb0a6aff4"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("6d5f444d-81b4-431b-be87-19a40ecdb057"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("8b901c31-790a-4970-8f26-7901e5e7b0f9"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("9b623cda-dfe9-4f91-bfdd-f823836c9c15"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("ed50dd1c-fe89-4ef4-8b8b-86618735c9e6"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("0bfaf032-9aa9-4e84-b3ad-bfe17255add2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("717dce66-dcfa-4e01-892f-f761e4ba7763"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("d81f35ad-8750-4583-ac0e-139038abfeb5"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("eb1c6759-bd26-4f7a-9c4e-c51c0d81cc32"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("f9b7892d-8aba-4ab4-b955-ed46389974d7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("512cf972-3243-4c6f-9104-ce27840761bf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("8935bf6f-9d21-457b-8ffe-db59fb62e67f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("9e82335a-a6a4-4d9f-80e7-6ec16796d805"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("c8b90012-799c-4f48-9bc5-5e7e6c078176"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d743b4b7-e678-47bd-ae23-f3e020d2df3c"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("371ce211-a9e5-449b-8831-73b86215e731"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("4c96e903-15dd-4324-8ac5-11728e11157a"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("6e7d8651-5749-4fe4-a390-3ff38924b5ff"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("ac84bf8d-8069-4053-a6e6-f7d9cf44586d"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("e39fd3be-2166-4f29-a8f4-016dbb2a29f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("0f4aa11c-0229-451f-beb6-8fbf5c5fe78c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("2adf2763-c05c-4aa7-b723-9b123fee82a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("8ff70092-a2e9-4252-9121-ac240f483bcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("bc3d327b-e507-4b8d-b288-b508a5bd8541"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("fb5e724c-d2d7-4dc7-8802-05f2be059cb3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("11d4a31c-fa68-49a2-b322-33a688d04d9d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("37df3ca7-25a0-4a3a-8e2b-d3a115c682aa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("edb83d40-33cc-4b5a-8920-0893db8d4011"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("efe28c17-c840-4ceb-b199-d6d6803ce4d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("f272fe85-de68-454f-a6f5-7bc4bf6ba436"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("201f96e8-47d1-4e73-bb8d-5c5cb9c9bfac"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("287f3992-02c1-4fc0-8174-983d89f4d9dc"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("3b227203-0f3f-4f9e-be2b-727a9f4b2763"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("6c524360-917e-4551-9a9e-80936c537e10"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("97e3b230-2d00-4df4-bcf6-adf7cd71dc4e"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("55fffae5-8646-4e3c-ada2-83af23568a27"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("74c176e0-d7ee-43a4-a183-e06477619362"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("a43fa8d5-7ff5-41ae-8b4f-568c173e50cf"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("b0bf62bd-9b6e-4f1d-bfb7-1005b911f959"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("dd7763f3-359b-4179-a04b-26ff94128b72"));

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "ColorCode", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("99763dd5-235f-4fc4-ae5f-b56b3bf9e3e2"), "C4", new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3235), "Yellow", "Active" },
                    { new Guid("a79a7f7d-b00c-48d3-9215-30d7986ef1c9"), "C1", new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3219), "Red", "Active" },
                    { new Guid("a7dbdfdd-4f60-4ec3-b608-366e7e054c3d"), "C5", new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3237), "Black", "Active" },
                    { new Guid("e276c461-3f23-41af-aecd-0bb28e368934"), "C3", new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3234), "Green", "Active" },
                    { new Guid("e295d080-0131-4c47-a90c-9ab2b87d1009"), "C2", new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3233), "Blue", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "DateCreated", "Email", "FullName", "Password", "PhoneNumber", "ResetPassword", "Sex", "UserName" },
                values: new object[,]
                {
                    { new Guid("2db21e69-cc89-45c5-8de5-2893ab10277f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2648), "customer4@example.com", "Customer 4", "password", "4321432143", "reset4", "Female", "customer4" },
                    { new Guid("7e95ffd5-df8a-4eed-8998-6c22a91caa48"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2646), "customer3@example.com", "Customer 3", "password", "1231231234", "reset3", "Male", "customer3" },
                    { new Guid("beb23968-4803-439f-a66c-16af00ca3a06"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2645), "customer2@example.com", "Customer 2", "password", "0987654321", "reset2", "Female", "customer2" },
                    { new Guid("e0285d6e-78eb-4275-a67a-22515dcec565"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2650), "customer5@example.com", "Customer 5", "password", "6789678967", "reset5", "Male", "customer5" },
                    { new Guid("e57b1ee4-a901-410d-bdbe-2d6d146579f4"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2639), "customer1@example.com", "Customer 1", "password", "1234567890", "reset1", "Male", "customer1" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageID", "DateCreated", "ImageCode", "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("218199f6-835e-4ac8-ab74-4331c8d1883f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3494), "IMG2", "https://example.com/img2_1.jpg", "https://example.com/img2_2.jpg", "https://example.com/img2_3.jpg", "https://example.com/img2_4.jpg", "Image 2", "Active" },
                    { new Guid("a412e4c2-2888-47d7-954f-757c248f8fc1"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3495), "IMG3", "https://example.com/img3_1.jpg", "https://example.com/img3_2.jpg", "https://example.com/img3_3.jpg", "https://example.com/img3_4.jpg", "Image 3", "Active" },
                    { new Guid("aebc501c-a0c2-475c-bd8b-ad8d9715fb61"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3500), "IMG5", "https://example.com/img5_1.jpg", "https://example.com/img5_2.jpg", "https://example.com/img5_3.jpg", "https://example.com/img5_4.jpg", "Image 5", "Active" },
                    { new Guid("e3b8ac43-dc98-4a46-a45b-4c46c8b1acb6"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3484), "IMG1", "https://example.com/img1_1.jpg", "https://example.com/img1_2.jpg", "https://example.com/img1_3.jpg", "https://example.com/img1_4.jpg", "Image 1", "Active" },
                    { new Guid("fe904674-9712-43bc-98f6-87cd32e1a6a0"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3498), "IMG4", "https://example.com/img4_1.jpg", "https://example.com/img4_2.jpg", "https://example.com/img4_3.jpg", "https://example.com/img4_4.jpg", "Image 4", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialID", "DateCreated", "MaterialCode", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("064436ea-9e31-41d6-9459-64d39262beb2"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3345), "M1", "Leather", "Active" },
                    { new Guid("86901f99-67c0-4017-93cd-012df6de81fd"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3358), "M4", "Synthetic", "Active" },
                    { new Guid("af29784a-9aaa-4eea-b4de-6dfa0c011d59"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3350), "M3", "Canvas", "Active" },
                    { new Guid("c055fe2a-926a-44db-b581-2f8f2b5d84fb"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3349), "M2", "Suede", "Active" },
                    { new Guid("c587a43a-b000-4314-a22c-37d74927f96a"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3359), "M5", "Rubber", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "DateCreated", "Name", "ProductCode", "Status" },
                values: new object[,]
                {
                    { new Guid("2a134f4d-195a-4c22-901f-e0dc1d2ab55a"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3440), "Sandals", "P4", "Active" },
                    { new Guid("9bb6db80-e759-4b19-aa2e-3c53d12c34b9"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3441), "Formal Shoes", "P5", "Active" },
                    { new Guid("a178a436-62c2-4bbe-a9a6-aca29bd78644"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3436), "Boots", "P3", "Active" },
                    { new Guid("b29652e2-df38-4d56-8024-3e8f5cb591fd"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3426), "Running Shoes", "P1", "Active" },
                    { new Guid("ed99f993-00f4-450b-8664-b14f427343aa"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3435), "Sneakers", "P2", "Active" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseMethods",
                columns: new[] { "PurchaseMethodID", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("10451571-ce23-44aa-905a-e85f09dca9b9"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2993), "Cryptocurrency", "Active" },
                    { new Guid("4ec57afa-f317-4aae-939f-82092b7f47b5"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2991), "Bank Transfer", "Active" },
                    { new Guid("9ebd0022-01d3-4c80-9563-ecb38251f56d"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2989), "PayPal", "Active" },
                    { new Guid("b3ea1118-ae19-4c05-8c4f-e3841f35691c"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2990), "Cash", "Active" },
                    { new Guid("e9aeca0c-9123-4fd5-9f40-84916947dd57"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2983), "Credit Card", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "DateCreated", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("4f21a905-a8ff-4d5a-9687-5bca6bf0c72f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2833), "R2", "User" },
                    { new Guid("83fc2d1b-5bad-42c0-9b82-27bdd606fbed"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2840), "R5", "Guest" },
                    { new Guid("b337e26e-e213-41ce-8e0a-fc54da77eba2"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2829), "R1", "Admin" },
                    { new Guid("e3f5908b-c34b-4f2f-830e-b4c85f6e180f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2836), "R4", "Support" },
                    { new Guid("f9771605-ed9c-4cb1-ab40-205df0a20e5f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2835), "R3", "Manager" }
                });

            migrationBuilder.InsertData(
                table: "Sexes",
                columns: new[] { "SexID", "SexName" },
                values: new object[,]
                {
                    { new Guid("43f89f17-19a1-4cd0-927e-3ba4a87a7947"), "Male" },
                    { new Guid("80de469b-8706-4bf1-893a-0f2d29d34ee8"), "Others" },
                    { new Guid("d86b3d83-b45c-41b5-9ca2-18b5794e94da"), "Female" },
                    { new Guid("df6dcf7e-fc97-4713-98d5-b99ee4d1cbff"), "Kids" },
                    { new Guid("ec04c798-4084-459e-8860-4d7bbb41d968"), "Unisex" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("391f05a6-9129-4896-ace5-fe223494b133"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3161), "Size 2", "S2", "Active" },
                    { new Guid("3ca0552f-87e3-4873-b7de-4dff6fbf0f98"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3158), "Size 1", "S1", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("4e63eb70-2e11-4bfc-a831-e5548f8b8ad3"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3167), "Size 5", "S5", "Active" },
                    { new Guid("7d532075-a527-40dc-b10d-ddd0bfc1ab63"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3166), "Size 4", "S4", "Active" },
                    { new Guid("b984d187-6dd1-45cd-9973-3d0e6f7026a1"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3165), "Size 3", "S3", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "StyleID", "DateCreated", "Name", "Status", "StyleCode" },
                values: new object[,]
                {
                    { new Guid("0a368238-1881-4be3-847a-a7f1b247bdb6"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3583), "Work", "Active", "ST5" },
                    { new Guid("1d8f9640-1937-4cee-a8cc-5f871517bfed"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3571), "Casual", "Active", "ST1" },
                    { new Guid("78a3a78b-474b-4c23-9c7f-52a3cb65c274"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3579), "Outdoor", "Active", "ST4" },
                    { new Guid("8b6542d7-9102-40f0-a837-2340449c4561"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3578), "Formal", "Active", "ST3" },
                    { new Guid("fb127de1-371c-4051-b695-0463d785d4b4"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3576), "Sport", "Active", "ST2" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherID", "DateCreated", "ExpirationDate", "MaxUsage", "RemainingUsage", "Status", "Total", "VoucherCode", "VoucherValue" },
                values: new object[,]
                {
                    { new Guid("2fa517bd-0f4d-4315-8a60-d3a3f50f7c67"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2909), new DateTime(2024, 6, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2909), 10m, 3m, true, 1000, "VC3", 300m },
                    { new Guid("3a72329e-37ae-43aa-ab33-223b82131d4f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2904), new DateTime(2024, 6, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2904), 10m, 4m, true, 1000, "VC2", 200m },
                    { new Guid("6e012097-4f27-41cd-8778-8c1d835ca77a"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2895), new DateTime(2024, 6, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2895), 10m, 5m, true, 1000, "VC1", 100m },
                    { new Guid("c7feac47-13ae-47bb-a192-b04d147766a8"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2956), new DateTime(2024, 6, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2956), 10m, 1m, true, 1000, "VC5", 500m },
                    { new Guid("c9e42695-d9ab-466c-a23b-6ec49aa3f4fb"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2953), new DateTime(2024, 6, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2953), 10m, 2m, true, 1000, "VC4", 400m }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "Commune", "CustomerID", "DateCreated", "District", "DistrictCode", "IsDefaultAddress", "Province", "ShippingCost", "Status", "Street", "WardCode" },
                values: new object[,]
                {
                    { new Guid("046f153b-d58a-4cef-b6f5-e17d0a83de99"), "Commune 1", new Guid("e57b1ee4-a901-410d-bdbe-2d6d146579f4"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2777), "District 1", "D1", true, "Province 1", 10m, "Active", "Street 1", "W1" },
                    { new Guid("2075e02d-9c0f-4d7c-9f66-636525b82cd1"), "Commune 5", new Guid("e0285d6e-78eb-4275-a67a-22515dcec565"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2802), "District 5", "D5", true, "Province 5", 50m, "Active", "Street 5", "W5" },
                    { new Guid("7a10de1b-7ced-40a1-b350-22b578699bbd"), "Commune 2", new Guid("beb23968-4803-439f-a66c-16af00ca3a06"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2794), "District 2", "D2", false, "Province 2", 20m, "Active", "Street 2", "W2" },
                    { new Guid("8a30df15-c1f2-42d7-bf87-21161879ede7"), "Commune 3", new Guid("7e95ffd5-df8a-4eed-8998-6c22a91caa48"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2797), "District 3", "D3", true, "Province 3", 30m, "Active", "Street 3", "W3" },
                    { new Guid("f2bf807d-8f06-4c67-8ee5-9e5ce95a13d3"), "Commune 4", new Guid("2db21e69-cc89-45c5-8de5-2893ab10277f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2800), "District 4", "D4", false, "Province 4", 40m, "Active", "Street 4", "W4" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "CustomerID", "Description" },
                values: new object[,]
                {
                    { new Guid("254407d4-96e8-4165-bae7-45f57c04afad"), new Guid("e0285d6e-78eb-4275-a67a-22515dcec565"), "Customer 5's Cart" },
                    { new Guid("2ee1fa59-c6b7-45b1-8f55-0b4ef770f05c"), new Guid("e57b1ee4-a901-410d-bdbe-2d6d146579f4"), "Customer 1's Cart" },
                    { new Guid("7847673c-13b0-48c9-aec7-9913427dd17b"), new Guid("2db21e69-cc89-45c5-8de5-2893ab10277f"), "Customer 4's Cart" },
                    { new Guid("92ab9bc5-a655-4df0-bc77-ec987998d36c"), new Guid("beb23968-4803-439f-a66c-16af00ca3a06"), "Customer 2's Cart" },
                    { new Guid("995a1937-36e7-4f19-a6bf-4d186ab49264"), new Guid("7e95ffd5-df8a-4eed-8998-6c22a91caa48"), "Customer 3's Cart" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateCreated", "Email", "FullName", "IdentificationCode", "Image", "Password", "PhoneNumber", "RoleID", "Sex", "Status", "UserName" },
                values: new object[,]
                {
                    { new Guid("b0880b58-0326-4410-9be3-b3430a9b0b4a"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2876), "employee5@example.com", "Employee 5", "ID5", "img5.png", "password", "6789678967", new Guid("83fc2d1b-5bad-42c0-9b82-27bdd606fbed"), "Male", "Active", "employee5" },
                    { new Guid("b1f6048c-8d34-4aaf-a30a-01afb06c1046"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2865), "employee1@example.com", "Employee 1", "ID1", "img1.png", "password", "1234567890", new Guid("b337e26e-e213-41ce-8e0a-fc54da77eba2"), "Male", "Active", "employee1" },
                    { new Guid("b46cea3b-a766-4980-a82f-3c8dde26a234"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2874), "employee4@example.com", "Employee 4", "ID4", "img4.png", "password", "4321432143", new Guid("e3f5908b-c34b-4f2f-830e-b4c85f6e180f"), "Female", "Active", "employee4" },
                    { new Guid("cdb4cd64-5203-47f5-b435-da340b5d8988"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2872), "employee3@example.com", "Employee 3", "ID3", "img3.png", "password", "1231231234", new Guid("f9771605-ed9c-4cb1-ab40-205df0a20e5f"), "Male", "Active", "employee3" },
                    { new Guid("e54f69ea-4917-479d-8054-c3bd13457b4c"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(2870), "employee2@example.com", "Employee 2", "ID2", "img2.png", "password", "0987654321", new Guid("4f21a905-a8ff-4d5a-9687-5bca6bf0c72f"), "Female", "Active", "employee2" }
                });

            migrationBuilder.InsertData(
                table: "ShoesDetails",
                columns: new[] { "ShoesDetailsID", "ColorID", "Description", "ImageID", "ImportPrice", "MaterialID", "Price", "ProductID", "SexID", "ShoesDetailsCode", "ShoesDetails_SizeID", "Status", "StyleID" },
                values: new object[,]
                {
                    { new Guid("2634ab46-ccf7-42fd-a846-6107c78428c3"), new Guid("a7dbdfdd-4f60-4ec3-b608-366e7e054c3d"), "Formal Shoes", new Guid("aebc501c-a0c2-475c-bd8b-ad8d9715fb61"), 4000m, new Guid("c587a43a-b000-4314-a22c-37d74927f96a"), 5000m, new Guid("9bb6db80-e759-4b19-aa2e-3c53d12c34b9"), new Guid("80de469b-8706-4bf1-893a-0f2d29d34ee8"), "SD5", new Guid("95c03d2f-dba4-4887-bcc6-d040fad5e7f7"), "Active", new Guid("0a368238-1881-4be3-847a-a7f1b247bdb6") },
                    { new Guid("61629585-34fa-4609-8f3d-d7f92ceccd96"), new Guid("e295d080-0131-4c47-a90c-9ab2b87d1009"), "Sneakers", new Guid("218199f6-835e-4ac8-ab74-4331c8d1883f"), 1600m, new Guid("c055fe2a-926a-44db-b581-2f8f2b5d84fb"), 2000m, new Guid("ed99f993-00f4-450b-8664-b14f427343aa"), new Guid("d86b3d83-b45c-41b5-9ca2-18b5794e94da"), "SD2", new Guid("6d0e72bd-6a5d-494e-bc3a-d44a9fe6571d"), "Active", new Guid("fb127de1-371c-4051-b695-0463d785d4b4") },
                    { new Guid("7c2ea359-11ab-4ff4-8c6f-66017b915dea"), new Guid("e276c461-3f23-41af-aecd-0bb28e368934"), "Boots", new Guid("a412e4c2-2888-47d7-954f-757c248f8fc1"), 2400m, new Guid("af29784a-9aaa-4eea-b4de-6dfa0c011d59"), 3000m, new Guid("a178a436-62c2-4bbe-a9a6-aca29bd78644"), new Guid("ec04c798-4084-459e-8860-4d7bbb41d968"), "SD3", new Guid("d667e0b2-3bbc-43bb-8db4-613396bbf93d"), "Active", new Guid("8b6542d7-9102-40f0-a837-2340449c4561") },
                    { new Guid("952fcb48-fb07-4aa2-ad89-05c02cb6d009"), new Guid("a79a7f7d-b00c-48d3-9215-30d7986ef1c9"), "Running Shoes", new Guid("e3b8ac43-dc98-4a46-a45b-4c46c8b1acb6"), 800m, new Guid("064436ea-9e31-41d6-9459-64d39262beb2"), 1000m, new Guid("b29652e2-df38-4d56-8024-3e8f5cb591fd"), new Guid("43f89f17-19a1-4cd0-927e-3ba4a87a7947"), "SD1", new Guid("3ba54090-777d-47c7-b4a7-f4e657d7dd9f"), "Active", new Guid("1d8f9640-1937-4cee-a8cc-5f871517bfed") },
                    { new Guid("c2ccb2a5-1f66-4900-b05f-f0ca9e7334a1"), new Guid("99763dd5-235f-4fc4-ae5f-b56b3bf9e3e2"), "Sandals", new Guid("fe904674-9712-43bc-98f6-87cd32e1a6a0"), 3200m, new Guid("86901f99-67c0-4017-93cd-012df6de81fd"), 4000m, new Guid("2a134f4d-195a-4c22-901f-e0dc1d2ab55a"), new Guid("df6dcf7e-fc97-4713-98d5-b99ee4d1cbff"), "SD4", new Guid("ee66ef88-f4cf-462e-a8f7-0ed83133a167"), "Active", new Guid("78a3a78b-474b-4c23-9c7f-52a3cb65c274") }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "ID", "BillCode", "CancelDate", "ConfirmationDate", "CustomerID", "DateCreated", "DeliveryDate", "EmployeeID", "IsPaid", "Note", "PaymentDay", "PurchaseMethodID", "ShippingCosts", "Status", "SuccessDate", "TotalPrice", "TotalPriceAfterDiscount", "TransactionType", "UpdateDate", "VoucherID" },
                values: new object[,]
                {
                    { new Guid("28364be2-a65b-4fc1-aad7-8dccc9bbd448"), "B2", null, new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3035), new Guid("beb23968-4803-439f-a66c-16af00ca3a06"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3033), new DateTime(2024, 5, 25, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3034), new Guid("e54f69ea-4917-479d-8054-c3bd13457b4c"), true, "Note 2", new DateTime(2024, 5, 23, 10, 9, 20, 889, DateTimeKind.Utc).AddTicks(3036), new Guid("9ebd0022-01d3-4c80-9563-ecb38251f56d"), 100m, "Delivered", new DateTime(2024, 5, 24, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3034), 2000m, 1900m, "Credit", new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3036), new Guid("3a72329e-37ae-43aa-ab33-223b82131d4f") },
                    { new Guid("4b267549-53f5-4143-85dd-4508bbc92cf0"), "B1", null, new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3022), new Guid("e57b1ee4-a901-410d-bdbe-2d6d146579f4"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3015), new DateTime(2024, 5, 25, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3021), new Guid("b1f6048c-8d34-4aaf-a30a-01afb06c1046"), true, "Note 1", new DateTime(2024, 5, 23, 10, 9, 20, 889, DateTimeKind.Utc).AddTicks(3024), new Guid("e9aeca0c-9123-4fd5-9f40-84916947dd57"), 50m, "Delivered", new DateTime(2024, 5, 24, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3016), 1000m, 950m, "Credit", new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3023), new Guid("6e012097-4f27-41cd-8778-8c1d835ca77a") },
                    { new Guid("4df74ef5-e366-4e35-8ddf-d4886e4518d5"), "B4", null, new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3046), new Guid("2db21e69-cc89-45c5-8de5-2893ab10277f"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3045), new DateTime(2024, 5, 25, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3045), new Guid("b46cea3b-a766-4980-a82f-3c8dde26a234"), true, "Note 4", new DateTime(2024, 5, 23, 10, 9, 20, 889, DateTimeKind.Utc).AddTicks(3047), new Guid("4ec57afa-f317-4aae-939f-82092b7f47b5"), 200m, "Delivered", new DateTime(2024, 5, 24, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3045), 4000m, 3800m, "Credit", new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3046), new Guid("c9e42695-d9ab-466c-a23b-6ec49aa3f4fb") },
                    { new Guid("9b901a47-24a8-4a33-85ba-53553802fe79"), "B5", null, new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3051), new Guid("e0285d6e-78eb-4275-a67a-22515dcec565"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3050), new DateTime(2024, 5, 25, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3050), new Guid("b0880b58-0326-4410-9be3-b3430a9b0b4a"), true, "Note 5", new DateTime(2024, 5, 23, 10, 9, 20, 889, DateTimeKind.Utc).AddTicks(3052), new Guid("10451571-ce23-44aa-905a-e85f09dca9b9"), 250m, "Delivered", new DateTime(2024, 5, 24, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3050), 5000m, 4750m, "Credit", new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3051), new Guid("c7feac47-13ae-47bb-a192-b04d147766a8") },
                    { new Guid("a7f28647-512e-4273-a96a-9722fb161072"), "B3", null, new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3041), new Guid("7e95ffd5-df8a-4eed-8998-6c22a91caa48"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3040), new DateTime(2024, 5, 25, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3040), new Guid("cdb4cd64-5203-47f5-b435-da340b5d8988"), true, "Note 3", new DateTime(2024, 5, 23, 10, 9, 20, 889, DateTimeKind.Utc).AddTicks(3042), new Guid("b3ea1118-ae19-4c05-8c4f-e3841f35691c"), 150m, "Delivered", new DateTime(2024, 5, 24, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3040), 3000m, 2850m, "Credit", new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3042), new Guid("2fa517bd-0f4d-4315-8a60-d3a3f50f7c67") }
                });

            migrationBuilder.InsertData(
                table: "ShoesDetails_Sizes",
                columns: new[] { "ID", "Quantity", "ShoesDetailsID", "SizeID" },
                values: new object[,]
                {
                    { new Guid("144fed91-8d53-4233-b6af-8f92899ec105"), 30, new Guid("7c2ea359-11ab-4ff4-8c6f-66017b915dea"), new Guid("b984d187-6dd1-45cd-9973-3d0e6f7026a1") },
                    { new Guid("5a604a68-cac2-4e69-8754-b16d43f33a62"), 20, new Guid("61629585-34fa-4609-8f3d-d7f92ceccd96"), new Guid("391f05a6-9129-4896-ace5-fe223494b133") },
                    { new Guid("955c1385-1f0a-48d4-94f2-c4cd5424a99d"), 40, new Guid("c2ccb2a5-1f66-4900-b05f-f0ca9e7334a1"), new Guid("7d532075-a527-40dc-b10d-ddd0bfc1ab63") },
                    { new Guid("c5c2ab74-60a6-4e1a-8401-6a9b06291deb"), 10, new Guid("952fcb48-fb07-4aa2-ad89-05c02cb6d009"), new Guid("3ca0552f-87e3-4873-b7de-4dff6fbf0f98") },
                    { new Guid("ef78fc43-6f1c-40c5-b508-29fb41f2c7db"), 50, new Guid("2634ab46-ccf7-42fd-a846-6107c78428c3"), new Guid("4e63eb70-2e11-4bfc-a831-e5548f8b8ad3") }
                });

            migrationBuilder.InsertData(
                table: "BillDetails",
                columns: new[] { "ID", "BillID", "Price", "Quantity", "ShoesDetails_SizeID", "Status" },
                values: new object[,]
                {
                    { new Guid("025c59e9-e21a-47e4-828f-ee88e66431d9"), new Guid("28364be2-a65b-4fc1-aad7-8dccc9bbd448"), 2000m, 2, new Guid("081bbc13-e243-4881-bd89-cb630bd7d75c"), "Delivered" },
                    { new Guid("26f127f5-046b-4dcf-a810-04e8531f9b15"), new Guid("4df74ef5-e366-4e35-8ddf-d4886e4518d5"), 4000m, 4, new Guid("2208900f-a6ae-457a-8cc2-97e4aaa686e2"), "Delivered" },
                    { new Guid("4c6b84c8-1c6d-4a9b-864e-cbb2436aa963"), new Guid("9b901a47-24a8-4a33-85ba-53553802fe79"), 5000m, 5, new Guid("887f2cbf-b35c-4ea8-9ac2-91871ac785ea"), "Delivered" },
                    { new Guid("6d70bb19-4161-43fc-9c37-cff08164dffc"), new Guid("4b267549-53f5-4143-85dd-4508bbc92cf0"), 1000m, 1, new Guid("58eae792-ff6a-4d0c-bab0-e316c21c12a3"), "Delivered" },
                    { new Guid("790f4e27-344a-4c11-a3f9-3cd89d9b05b0"), new Guid("a7f28647-512e-4273-a96a-9722fb161072"), 3000m, 3, new Guid("e0b5fcbd-ffca-4fa0-8cfc-da2d14b60a94"), "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "BillStatusHistories",
                columns: new[] { "BillStatusHistoryID", "BillID", "ChangeDate", "Note", "Status" },
                values: new object[,]
                {
                    { new Guid("19dc3593-1bc2-4c2e-9e49-11f46bcd55e0"), new Guid("a7f28647-512e-4273-a96a-9722fb161072"), new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3124), "Order shipped", "Shipped" },
                    { new Guid("26b85f1e-a345-4fc4-bb2c-7aa8d9a21ef6"), new Guid("4b267549-53f5-4143-85dd-4508bbc92cf0"), new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3115), "Order delivered", "Delivered" },
                    { new Guid("2f0b2f59-6b35-429e-ac53-dc08b823d71b"), new Guid("28364be2-a65b-4fc1-aad7-8dccc9bbd448"), new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3121), "Order delivered", "Delivered" },
                    { new Guid("575644d6-8a8b-421e-bbd1-b7852ce21874"), new Guid("28364be2-a65b-4fc1-aad7-8dccc9bbd448"), new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3118), "Order shipped", "Shipped" },
                    { new Guid("59595e9f-d59d-493d-a860-567625454305"), new Guid("4df74ef5-e366-4e35-8ddf-d4886e4518d5"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3130), "Order placed", "Ordered" },
                    { new Guid("6d87a836-866e-43ee-be0a-b71734be8498"), new Guid("28364be2-a65b-4fc1-aad7-8dccc9bbd448"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3117), "Order placed", "Ordered" },
                    { new Guid("84ffa2f4-26e6-4e59-95e4-da0ea98495f3"), new Guid("4b267549-53f5-4143-85dd-4508bbc92cf0"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3106), "Order placed", "Ordered" },
                    { new Guid("8a58f66e-99a9-47d4-9df6-bfc3b45be3eb"), new Guid("9b901a47-24a8-4a33-85ba-53553802fe79"), new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3137), "Order delivered", "Delivered" },
                    { new Guid("a68a8961-a2c0-417d-8bed-af3eb3f968da"), new Guid("4df74ef5-e366-4e35-8ddf-d4886e4518d5"), new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3133), "Order delivered", "Delivered" },
                    { new Guid("aa0067f9-9481-4ec3-935c-16323f8bcaaf"), new Guid("4b267549-53f5-4143-85dd-4508bbc92cf0"), new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3113), "Order shipped", "Shipped" },
                    { new Guid("b6322f3e-ada6-4dbc-b7d7-ac918674bdb1"), new Guid("4df74ef5-e366-4e35-8ddf-d4886e4518d5"), new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3131), "Order shipped", "Shipped" },
                    { new Guid("bb28baed-5e5e-4910-82f0-b5c52ec5bdf8"), new Guid("9b901a47-24a8-4a33-85ba-53553802fe79"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3134), "Order placed", "Ordered" },
                    { new Guid("dafd196d-aef1-4aaa-9a29-b4ace6274d9f"), new Guid("a7f28647-512e-4273-a96a-9722fb161072"), new DateTime(2024, 5, 23, 9, 9, 20, 889, DateTimeKind.Utc).AddTicks(3125), "Order delivered", "Delivered" },
                    { new Guid("f2a02c93-abdc-4025-809d-70cdac0d5a29"), new Guid("a7f28647-512e-4273-a96a-9722fb161072"), new DateTime(2024, 5, 23, 7, 9, 20, 889, DateTimeKind.Utc).AddTicks(3122), "Order placed", "Ordered" },
                    { new Guid("f3555493-5bbe-4263-9d23-ba74fc715145"), new Guid("9b901a47-24a8-4a33-85ba-53553802fe79"), new DateTime(2024, 5, 23, 8, 9, 20, 889, DateTimeKind.Utc).AddTicks(3136), "Order shipped", "Shipped" }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "ID", "CartID", "Quantity", "ShoesDetails_SizeID" },
                values: new object[,]
                {
                    { new Guid("71911d43-c621-4964-b1ba-11cc284d4e92"), new Guid("995a1937-36e7-4f19-a6bf-4d186ab49264"), 3, new Guid("144fed91-8d53-4233-b6af-8f92899ec105") },
                    { new Guid("7e973a68-9f37-4ea0-9b52-a0de58b7bbfb"), new Guid("2ee1fa59-c6b7-45b1-8f55-0b4ef770f05c"), 1, new Guid("c5c2ab74-60a6-4e1a-8401-6a9b06291deb") },
                    { new Guid("ca32e7b6-a673-4140-83ea-704bb2e8ad80"), new Guid("92ab9bc5-a655-4df0-bc77-ec987998d36c"), 2, new Guid("5a604a68-cac2-4e69-8754-b16d43f33a62") },
                    { new Guid("d6e0e42f-ea11-41de-9aed-38d43da73b19"), new Guid("7847673c-13b0-48c9-aec7-9913427dd17b"), 4, new Guid("955c1385-1f0a-48d4-94f2-c4cd5424a99d") },
                    { new Guid("d9075061-e63b-40b4-94fb-6bdda14429bc"), new Guid("254407d4-96e8-4165-bae7-45f57c04afad"), 5, new Guid("ef78fc43-6f1c-40c5-b508-29fb41f2c7db") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("046f153b-d58a-4cef-b6f5-e17d0a83de99"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("2075e02d-9c0f-4d7c-9f66-636525b82cd1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("7a10de1b-7ced-40a1-b350-22b578699bbd"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("8a30df15-c1f2-42d7-bf87-21161879ede7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("f2bf807d-8f06-4c67-8ee5-9e5ce95a13d3"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("025c59e9-e21a-47e4-828f-ee88e66431d9"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("26f127f5-046b-4dcf-a810-04e8531f9b15"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("4c6b84c8-1c6d-4a9b-864e-cbb2436aa963"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("6d70bb19-4161-43fc-9c37-cff08164dffc"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("790f4e27-344a-4c11-a3f9-3cd89d9b05b0"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("19dc3593-1bc2-4c2e-9e49-11f46bcd55e0"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("26b85f1e-a345-4fc4-bb2c-7aa8d9a21ef6"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("2f0b2f59-6b35-429e-ac53-dc08b823d71b"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("575644d6-8a8b-421e-bbd1-b7852ce21874"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("59595e9f-d59d-493d-a860-567625454305"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("6d87a836-866e-43ee-be0a-b71734be8498"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("84ffa2f4-26e6-4e59-95e4-da0ea98495f3"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("8a58f66e-99a9-47d4-9df6-bfc3b45be3eb"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("a68a8961-a2c0-417d-8bed-af3eb3f968da"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("aa0067f9-9481-4ec3-935c-16323f8bcaaf"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("b6322f3e-ada6-4dbc-b7d7-ac918674bdb1"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("bb28baed-5e5e-4910-82f0-b5c52ec5bdf8"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("dafd196d-aef1-4aaa-9a29-b4ace6274d9f"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("f2a02c93-abdc-4025-809d-70cdac0d5a29"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("f3555493-5bbe-4263-9d23-ba74fc715145"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("71911d43-c621-4964-b1ba-11cc284d4e92"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("7e973a68-9f37-4ea0-9b52-a0de58b7bbfb"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("ca32e7b6-a673-4140-83ea-704bb2e8ad80"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("d6e0e42f-ea11-41de-9aed-38d43da73b19"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("d9075061-e63b-40b4-94fb-6bdda14429bc"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("28364be2-a65b-4fc1-aad7-8dccc9bbd448"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("4b267549-53f5-4143-85dd-4508bbc92cf0"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("4df74ef5-e366-4e35-8ddf-d4886e4518d5"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("9b901a47-24a8-4a33-85ba-53553802fe79"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("a7f28647-512e-4273-a96a-9722fb161072"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("254407d4-96e8-4165-bae7-45f57c04afad"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("2ee1fa59-c6b7-45b1-8f55-0b4ef770f05c"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("7847673c-13b0-48c9-aec7-9913427dd17b"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("92ab9bc5-a655-4df0-bc77-ec987998d36c"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("995a1937-36e7-4f19-a6bf-4d186ab49264"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("144fed91-8d53-4233-b6af-8f92899ec105"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("5a604a68-cac2-4e69-8754-b16d43f33a62"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("955c1385-1f0a-48d4-94f2-c4cd5424a99d"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("c5c2ab74-60a6-4e1a-8401-6a9b06291deb"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails_Sizes",
                keyColumn: "ID",
                keyValue: new Guid("ef78fc43-6f1c-40c5-b508-29fb41f2c7db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("2db21e69-cc89-45c5-8de5-2893ab10277f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("7e95ffd5-df8a-4eed-8998-6c22a91caa48"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("beb23968-4803-439f-a66c-16af00ca3a06"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("e0285d6e-78eb-4275-a67a-22515dcec565"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("e57b1ee4-a901-410d-bdbe-2d6d146579f4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("b0880b58-0326-4410-9be3-b3430a9b0b4a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("b1f6048c-8d34-4aaf-a30a-01afb06c1046"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("b46cea3b-a766-4980-a82f-3c8dde26a234"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("cdb4cd64-5203-47f5-b435-da340b5d8988"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("e54f69ea-4917-479d-8054-c3bd13457b4c"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("10451571-ce23-44aa-905a-e85f09dca9b9"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("4ec57afa-f317-4aae-939f-82092b7f47b5"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("9ebd0022-01d3-4c80-9563-ecb38251f56d"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("b3ea1118-ae19-4c05-8c4f-e3841f35691c"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("e9aeca0c-9123-4fd5-9f40-84916947dd57"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("2634ab46-ccf7-42fd-a846-6107c78428c3"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("61629585-34fa-4609-8f3d-d7f92ceccd96"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("7c2ea359-11ab-4ff4-8c6f-66017b915dea"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("952fcb48-fb07-4aa2-ad89-05c02cb6d009"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("c2ccb2a5-1f66-4900-b05f-f0ca9e7334a1"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("391f05a6-9129-4896-ace5-fe223494b133"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("3ca0552f-87e3-4873-b7de-4dff6fbf0f98"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("4e63eb70-2e11-4bfc-a831-e5548f8b8ad3"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("7d532075-a527-40dc-b10d-ddd0bfc1ab63"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("b984d187-6dd1-45cd-9973-3d0e6f7026a1"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("2fa517bd-0f4d-4315-8a60-d3a3f50f7c67"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("3a72329e-37ae-43aa-ab33-223b82131d4f"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("6e012097-4f27-41cd-8778-8c1d835ca77a"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("c7feac47-13ae-47bb-a192-b04d147766a8"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("c9e42695-d9ab-466c-a23b-6ec49aa3f4fb"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("99763dd5-235f-4fc4-ae5f-b56b3bf9e3e2"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("a79a7f7d-b00c-48d3-9215-30d7986ef1c9"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("a7dbdfdd-4f60-4ec3-b608-366e7e054c3d"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("e276c461-3f23-41af-aecd-0bb28e368934"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("e295d080-0131-4c47-a90c-9ab2b87d1009"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("218199f6-835e-4ac8-ab74-4331c8d1883f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("a412e4c2-2888-47d7-954f-757c248f8fc1"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("aebc501c-a0c2-475c-bd8b-ad8d9715fb61"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("e3b8ac43-dc98-4a46-a45b-4c46c8b1acb6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("fe904674-9712-43bc-98f6-87cd32e1a6a0"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("064436ea-9e31-41d6-9459-64d39262beb2"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("86901f99-67c0-4017-93cd-012df6de81fd"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("af29784a-9aaa-4eea-b4de-6dfa0c011d59"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("c055fe2a-926a-44db-b581-2f8f2b5d84fb"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("c587a43a-b000-4314-a22c-37d74927f96a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("2a134f4d-195a-4c22-901f-e0dc1d2ab55a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("9bb6db80-e759-4b19-aa2e-3c53d12c34b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("a178a436-62c2-4bbe-a9a6-aca29bd78644"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("b29652e2-df38-4d56-8024-3e8f5cb591fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("ed99f993-00f4-450b-8664-b14f427343aa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("4f21a905-a8ff-4d5a-9687-5bca6bf0c72f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("83fc2d1b-5bad-42c0-9b82-27bdd606fbed"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("b337e26e-e213-41ce-8e0a-fc54da77eba2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("e3f5908b-c34b-4f2f-830e-b4c85f6e180f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("f9771605-ed9c-4cb1-ab40-205df0a20e5f"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("43f89f17-19a1-4cd0-927e-3ba4a87a7947"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("80de469b-8706-4bf1-893a-0f2d29d34ee8"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("d86b3d83-b45c-41b5-9ca2-18b5794e94da"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("df6dcf7e-fc97-4713-98d5-b99ee4d1cbff"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("ec04c798-4084-459e-8860-4d7bbb41d968"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("0a368238-1881-4be3-847a-a7f1b247bdb6"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("1d8f9640-1937-4cee-a8cc-5f871517bfed"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("78a3a78b-474b-4c23-9c7f-52a3cb65c274"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("8b6542d7-9102-40f0-a837-2340449c4561"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("fb127de1-371c-4051-b695-0463d785d4b4"));

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "ColorCode", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("0bfaf032-9aa9-4e84-b3ad-bfe17255add2"), "C4", new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9527), "Yellow", "Active" },
                    { new Guid("717dce66-dcfa-4e01-892f-f761e4ba7763"), "C1", new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9518), "Red", "Active" },
                    { new Guid("d81f35ad-8750-4583-ac0e-139038abfeb5"), "C3", new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9523), "Green", "Active" },
                    { new Guid("eb1c6759-bd26-4f7a-9c4e-c51c0d81cc32"), "C5", new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9528), "Black", "Active" },
                    { new Guid("f9b7892d-8aba-4ab4-b955-ed46389974d7"), "C2", new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9522), "Blue", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "DateCreated", "Email", "FullName", "Password", "PhoneNumber", "ResetPassword", "Sex", "UserName" },
                values: new object[,]
                {
                    { new Guid("43c31dbd-d843-4787-9cc4-475b0b06acef"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(8906), "customer5@example.com", "Customer 5", "password", "6789678967", "reset5", "Male", "customer5" },
                    { new Guid("44e439a3-e71f-4ade-9ffe-2d14b605f7ec"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(8894), "customer4@example.com", "Customer 4", "password", "4321432143", "reset4", "Female", "customer4" },
                    { new Guid("5f644f1c-b75a-43df-a184-4370469dcf04"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(8891), "customer2@example.com", "Customer 2", "password", "0987654321", "reset2", "Female", "customer2" },
                    { new Guid("eeb800ef-dc32-4a54-b72a-c8daf9cc7de9"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(8885), "customer1@example.com", "Customer 1", "password", "1234567890", "reset1", "Male", "customer1" },
                    { new Guid("fe90651c-fb43-4692-91f1-e415d4e0e4c4"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(8893), "customer3@example.com", "Customer 3", "password", "1231231234", "reset3", "Male", "customer3" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageID", "DateCreated", "ImageCode", "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("512cf972-3243-4c6f-9104-ce27840761bf"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9607), "IMG3", "https://example.com/img3_1.jpg", "https://example.com/img3_2.jpg", "https://example.com/img3_3.jpg", "https://example.com/img3_4.jpg", "Image 3", "Active" },
                    { new Guid("8935bf6f-9d21-457b-8ffe-db59fb62e67f"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9605), "IMG2", "https://example.com/img2_1.jpg", "https://example.com/img2_2.jpg", "https://example.com/img2_3.jpg", "https://example.com/img2_4.jpg", "Image 2", "Active" },
                    { new Guid("9e82335a-a6a4-4d9f-80e7-6ec16796d805"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9609), "IMG4", "https://example.com/img4_1.jpg", "https://example.com/img4_2.jpg", "https://example.com/img4_3.jpg", "https://example.com/img4_4.jpg", "Image 4", "Active" },
                    { new Guid("c8b90012-799c-4f48-9bc5-5e7e6c078176"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9612), "IMG5", "https://example.com/img5_1.jpg", "https://example.com/img5_2.jpg", "https://example.com/img5_3.jpg", "https://example.com/img5_4.jpg", "Image 5", "Active" },
                    { new Guid("d743b4b7-e678-47bd-ae23-f3e020d2df3c"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9602), "IMG1", "https://example.com/img1_1.jpg", "https://example.com/img1_2.jpg", "https://example.com/img1_3.jpg", "https://example.com/img1_4.jpg", "Image 1", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialID", "DateCreated", "MaterialCode", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("371ce211-a9e5-449b-8831-73b86215e731"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9554), "M3", "Canvas", "Active" },
                    { new Guid("4c96e903-15dd-4324-8ac5-11728e11157a"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9557), "M5", "Rubber", "Active" },
                    { new Guid("6e7d8651-5749-4fe4-a390-3ff38924b5ff"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9549), "M1", "Leather", "Active" },
                    { new Guid("ac84bf8d-8069-4053-a6e6-f7d9cf44586d"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9552), "M2", "Suede", "Active" },
                    { new Guid("e39fd3be-2166-4f29-a8f4-016dbb2a29f2"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9555), "M4", "Synthetic", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "DateCreated", "Name", "ProductCode", "Status" },
                values: new object[,]
                {
                    { new Guid("0f4aa11c-0229-451f-beb6-8fbf5c5fe78c"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9578), "Sneakers", "P2", "Active" },
                    { new Guid("2adf2763-c05c-4aa7-b723-9b123fee82a4"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9580), "Boots", "P3", "Active" },
                    { new Guid("8ff70092-a2e9-4252-9121-ac240f483bcf"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9573), "Running Shoes", "P1", "Active" },
                    { new Guid("bc3d327b-e507-4b8d-b288-b508a5bd8541"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9583), "Formal Shoes", "P5", "Active" },
                    { new Guid("fb5e724c-d2d7-4dc7-8802-05f2be059cb3"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9581), "Sandals", "P4", "Active" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseMethods",
                columns: new[] { "PurchaseMethodID", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("371563be-e757-4e15-a91a-103ea9fe4fd2"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9250), "Cash", "Active" },
                    { new Guid("65236c11-a1d5-4c88-983e-8ca95098cd9b"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9245), "Credit Card", "Active" },
                    { new Guid("7c3ac735-b408-4758-906c-dd6ef74e0c90"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9248), "PayPal", "Active" },
                    { new Guid("bd803e52-5fcb-41ba-9a6f-f1e5ba2d6d5b"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9253), "Bank Transfer", "Active" },
                    { new Guid("e204da23-bb6e-4167-a173-9f81da978195"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9255), "Cryptocurrency", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "DateCreated", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("11d4a31c-fa68-49a2-b322-33a688d04d9d"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9130), "R2", "User" },
                    { new Guid("37df3ca7-25a0-4a3a-8e2b-d3a115c682aa"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9136), "R4", "Support" },
                    { new Guid("edb83d40-33cc-4b5a-8920-0893db8d4011"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9125), "R1", "Admin" },
                    { new Guid("efe28c17-c840-4ceb-b199-d6d6803ce4d4"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9135), "R3", "Manager" },
                    { new Guid("f272fe85-de68-454f-a6f5-7bc4bf6ba436"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9138), "R5", "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Sexes",
                columns: new[] { "SexID", "SexName" },
                values: new object[,]
                {
                    { new Guid("201f96e8-47d1-4e73-bb8d-5c5cb9c9bfac"), "Male" },
                    { new Guid("287f3992-02c1-4fc0-8174-983d89f4d9dc"), "Others" },
                    { new Guid("3b227203-0f3f-4f9e-be2b-727a9f4b2763"), "Female" },
                    { new Guid("6c524360-917e-4551-9a9e-80936c537e10"), "Kids" },
                    { new Guid("97e3b230-2d00-4df4-bcf6-adf7cd71dc4e"), "Unisex" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("10c098fc-0c8d-46b4-a91c-ee9858959ae2"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9494), "Size 2", "S2", "Active" },
                    { new Guid("2d1c4cf3-feb9-429b-abfb-0fb37700194c"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9491), "Size 1", "S1", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("612836b0-f6c5-4cd5-b141-8c90b638d3c3"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9499), "Size 5", "S5", "Active" },
                    { new Guid("babcd2bb-4040-4082-8552-2e3af478802b"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9497), "Size 4", "S4", "Active" },
                    { new Guid("d849bd09-0183-4e6e-8ef8-7fe85b06000a"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9496), "Size 3", "S3", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "StyleID", "DateCreated", "Name", "Status", "StyleCode" },
                values: new object[,]
                {
                    { new Guid("55fffae5-8646-4e3c-ada2-83af23568a27"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9661), "Formal", "Active", "ST3" },
                    { new Guid("74c176e0-d7ee-43a4-a183-e06477619362"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9657), "Sport", "Active", "ST2" },
                    { new Guid("a43fa8d5-7ff5-41ae-8b4f-568c173e50cf"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9664), "Work", "Active", "ST5" },
                    { new Guid("b0bf62bd-9b6e-4f1d-bfb7-1005b911f959"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9662), "Outdoor", "Active", "ST4" },
                    { new Guid("dd7763f3-359b-4179-a04b-26ff94128b72"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9654), "Casual", "Active", "ST1" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherID", "DateCreated", "ExpirationDate", "MaxUsage", "RemainingUsage", "Status", "Total", "VoucherCode", "VoucherValue" },
                values: new object[,]
                {
                    { new Guid("09aa254d-74f3-49c2-a38e-84deb0a6aff4"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 6, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9210), 10m, 4m, true, 1000, "VC2", 200m },
                    { new Guid("6d5f444d-81b4-431b-be87-19a40ecdb057"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9200), new DateTime(2024, 6, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9201), 10m, 5m, true, 1000, "VC1", 100m },
                    { new Guid("8b901c31-790a-4970-8f26-7901e5e7b0f9"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9215), new DateTime(2024, 6, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9215), 10m, 2m, true, 1000, "VC4", 400m },
                    { new Guid("9b623cda-dfe9-4f91-bfdd-f823836c9c15"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9217), new DateTime(2024, 6, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9217), 10m, 1m, true, 1000, "VC5", 500m },
                    { new Guid("ed50dd1c-fe89-4ef4-8b8b-86618735c9e6"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9213), new DateTime(2024, 6, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9213), 10m, 3m, true, 1000, "VC3", 300m }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "Commune", "CustomerID", "DateCreated", "District", "DistrictCode", "IsDefaultAddress", "Province", "ShippingCost", "Status", "Street", "WardCode" },
                values: new object[,]
                {
                    { new Guid("0b24739a-76f8-4bf1-a100-97b706c84108"), "Commune 3", new Guid("fe90651c-fb43-4692-91f1-e415d4e0e4c4"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9048), "District 3", "D3", true, "Province 3", 30m, "Active", "Street 3", "W3" },
                    { new Guid("6afdf35b-11d9-4a8b-b305-2795fa116a9c"), "Commune 4", new Guid("44e439a3-e71f-4ade-9ffe-2d14b605f7ec"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9051), "District 4", "D4", false, "Province 4", 40m, "Active", "Street 4", "W4" },
                    { new Guid("7ccec7a8-9632-43da-8686-2310883160af"), "Commune 5", new Guid("43c31dbd-d843-4787-9cc4-475b0b06acef"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9053), "District 5", "D5", true, "Province 5", 50m, "Active", "Street 5", "W5" },
                    { new Guid("f1ba1903-5513-4d0c-9d80-c47619ef43da"), "Commune 2", new Guid("5f644f1c-b75a-43df-a184-4370469dcf04"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9046), "District 2", "D2", false, "Province 2", 20m, "Active", "Street 2", "W2" },
                    { new Guid("f830ea6f-b5f0-4f21-b486-bb38184f7afa"), "Commune 1", new Guid("eeb800ef-dc32-4a54-b72a-c8daf9cc7de9"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9038), "District 1", "D1", true, "Province 1", 10m, "Active", "Street 1", "W1" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "CustomerID", "Description" },
                values: new object[,]
                {
                    { new Guid("6cb952f1-16af-49b9-b06c-f2ec3d8c003d"), new Guid("5f644f1c-b75a-43df-a184-4370469dcf04"), "Customer 2's Cart" },
                    { new Guid("80522396-41a9-4191-8da8-2bee8fb1b318"), new Guid("44e439a3-e71f-4ade-9ffe-2d14b605f7ec"), "Customer 4's Cart" },
                    { new Guid("8564a625-bb01-43b5-856a-335aaf039ee1"), new Guid("eeb800ef-dc32-4a54-b72a-c8daf9cc7de9"), "Customer 1's Cart" },
                    { new Guid("d7af55e8-33ba-41c2-bf17-2bb26a249665"), new Guid("43c31dbd-d843-4787-9cc4-475b0b06acef"), "Customer 5's Cart" },
                    { new Guid("e5e44eb3-92fc-4b9b-8c6e-23eaee77361b"), new Guid("fe90651c-fb43-4692-91f1-e415d4e0e4c4"), "Customer 3's Cart" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateCreated", "Email", "FullName", "IdentificationCode", "Image", "Password", "PhoneNumber", "RoleID", "Sex", "Status", "UserName" },
                values: new object[,]
                {
                    { new Guid("9f0fb17c-dd4a-4938-99b6-e33146aee6ac"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9170), "employee3@example.com", "Employee 3", "ID3", "img3.png", "password", "1231231234", new Guid("efe28c17-c840-4ceb-b199-d6d6803ce4d4"), "Male", "Active", "employee3" },
                    { new Guid("a35828c1-9f12-4e96-b095-294f3a237d52"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9163), "employee1@example.com", "Employee 1", "ID1", "img1.png", "password", "1234567890", new Guid("edb83d40-33cc-4b5a-8920-0893db8d4011"), "Male", "Active", "employee1" },
                    { new Guid("a83aee0b-c02b-4f24-948d-a0e069d8007d"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9178), "employee5@example.com", "Employee 5", "ID5", "img5.png", "password", "6789678967", new Guid("f272fe85-de68-454f-a6f5-7bc4bf6ba436"), "Male", "Active", "employee5" },
                    { new Guid("db6d4430-1bab-4a99-8410-5cf1f1abe54a"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9168), "employee2@example.com", "Employee 2", "ID2", "img2.png", "password", "0987654321", new Guid("11d4a31c-fa68-49a2-b322-33a688d04d9d"), "Female", "Active", "employee2" },
                    { new Guid("eec176ba-59b8-4f0b-9c61-bf00cb3458f4"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9176), "employee4@example.com", "Employee 4", "ID4", "img4.png", "password", "4321432143", new Guid("37df3ca7-25a0-4a3a-8e2b-d3a115c682aa"), "Female", "Active", "employee4" }
                });

            migrationBuilder.InsertData(
                table: "ShoesDetails",
                columns: new[] { "ShoesDetailsID", "ColorID", "Description", "ImageID", "ImportPrice", "MaterialID", "Price", "ProductID", "SexID", "ShoesDetailsCode", "ShoesDetails_SizeID", "Status", "StyleID" },
                values: new object[,]
                {
                    { new Guid("274b28ab-d6f0-4a56-8dcf-fa7cbe1cb2c8"), new Guid("eb1c6759-bd26-4f7a-9c4e-c51c0d81cc32"), "Formal Shoes", new Guid("c8b90012-799c-4f48-9bc5-5e7e6c078176"), 4000m, new Guid("4c96e903-15dd-4324-8ac5-11728e11157a"), 5000m, new Guid("bc3d327b-e507-4b8d-b288-b508a5bd8541"), new Guid("287f3992-02c1-4fc0-8174-983d89f4d9dc"), "SD5", new Guid("5f1b22a6-aa28-4cd4-9cd7-8e40eb45cdaa"), "Active", new Guid("a43fa8d5-7ff5-41ae-8b4f-568c173e50cf") },
                    { new Guid("49e886b2-4517-49c9-a22a-0c9468994f61"), new Guid("717dce66-dcfa-4e01-892f-f761e4ba7763"), "Running Shoes", new Guid("d743b4b7-e678-47bd-ae23-f3e020d2df3c"), 800m, new Guid("6e7d8651-5749-4fe4-a390-3ff38924b5ff"), 1000m, new Guid("8ff70092-a2e9-4252-9121-ac240f483bcf"), new Guid("201f96e8-47d1-4e73-bb8d-5c5cb9c9bfac"), "SD1", new Guid("f787751b-14d0-427c-8501-14c524577bc9"), "Active", new Guid("dd7763f3-359b-4179-a04b-26ff94128b72") },
                    { new Guid("4e934ca4-e7cd-49db-ae2b-d587d786a847"), new Guid("d81f35ad-8750-4583-ac0e-139038abfeb5"), "Boots", new Guid("512cf972-3243-4c6f-9104-ce27840761bf"), 2400m, new Guid("371ce211-a9e5-449b-8831-73b86215e731"), 3000m, new Guid("2adf2763-c05c-4aa7-b723-9b123fee82a4"), new Guid("97e3b230-2d00-4df4-bcf6-adf7cd71dc4e"), "SD3", new Guid("500327dd-e2aa-4344-914a-318cc89f99fb"), "Active", new Guid("55fffae5-8646-4e3c-ada2-83af23568a27") },
                    { new Guid("e35d9c32-839a-4234-8e57-a7cc3d4bfd63"), new Guid("f9b7892d-8aba-4ab4-b955-ed46389974d7"), "Sneakers", new Guid("8935bf6f-9d21-457b-8ffe-db59fb62e67f"), 1600m, new Guid("ac84bf8d-8069-4053-a6e6-f7d9cf44586d"), 2000m, new Guid("0f4aa11c-0229-451f-beb6-8fbf5c5fe78c"), new Guid("3b227203-0f3f-4f9e-be2b-727a9f4b2763"), "SD2", new Guid("e62e73b0-18a9-40cc-a955-7c228cf4cccc"), "Active", new Guid("74c176e0-d7ee-43a4-a183-e06477619362") },
                    { new Guid("fc4c7431-458d-4dd9-a0ed-493a1cef8a38"), new Guid("0bfaf032-9aa9-4e84-b3ad-bfe17255add2"), "Sandals", new Guid("9e82335a-a6a4-4d9f-80e7-6ec16796d805"), 3200m, new Guid("e39fd3be-2166-4f29-a8f4-016dbb2a29f2"), 4000m, new Guid("fb5e724c-d2d7-4dc7-8802-05f2be059cb3"), new Guid("6c524360-917e-4551-9a9e-80936c537e10"), "SD4", new Guid("62689ff6-427e-405e-a100-4262ddc50169"), "Active", new Guid("b0bf62bd-9b6e-4f1d-bfb7-1005b911f959") }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "ID", "BillCode", "CancelDate", "ConfirmationDate", "CustomerID", "DateCreated", "DeliveryDate", "EmployeeID", "IsPaid", "Note", "PaymentDay", "PurchaseMethodID", "ShippingCosts", "Status", "SuccessDate", "TotalPrice", "TotalPriceAfterDiscount", "TransactionType", "UpdateDate", "VoucherID" },
                values: new object[,]
                {
                    { new Guid("2d41d790-a11a-4e9f-bcd9-1fe446d55632"), "B2", null, new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9297), new Guid("5f644f1c-b75a-43df-a184-4370469dcf04"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9295), new DateTime(2024, 5, 25, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9296), new Guid("db6d4430-1bab-4a99-8410-5cf1f1abe54a"), true, "Note 2", new DateTime(2024, 5, 23, 10, 8, 25, 447, DateTimeKind.Utc).AddTicks(9298), new Guid("7c3ac735-b408-4758-906c-dd6ef74e0c90"), 100m, "Delivered", new DateTime(2024, 5, 24, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9296), 2000m, 1900m, "Credit", new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9298), new Guid("09aa254d-74f3-49c2-a38e-84deb0a6aff4") },
                    { new Guid("350d9f52-717f-413e-8b1a-35d68e6c5703"), "B3", null, new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9304), new Guid("fe90651c-fb43-4692-91f1-e415d4e0e4c4"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9302), new DateTime(2024, 5, 25, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9303), new Guid("9f0fb17c-dd4a-4938-99b6-e33146aee6ac"), true, "Note 3", new DateTime(2024, 5, 23, 10, 8, 25, 447, DateTimeKind.Utc).AddTicks(9305), new Guid("371563be-e757-4e15-a91a-103ea9fe4fd2"), 150m, "Delivered", new DateTime(2024, 5, 24, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9303), 3000m, 2850m, "Credit", new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9304), new Guid("ed50dd1c-fe89-4ef4-8b8b-86618735c9e6") },
                    { new Guid("845d90bc-8661-4e3e-8f5d-1c6ad82d564b"), "B1", null, new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9287), new Guid("eeb800ef-dc32-4a54-b72a-c8daf9cc7de9"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9279), new DateTime(2024, 5, 25, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9285), new Guid("a35828c1-9f12-4e96-b095-294f3a237d52"), true, "Note 1", new DateTime(2024, 5, 23, 10, 8, 25, 447, DateTimeKind.Utc).AddTicks(9289), new Guid("65236c11-a1d5-4c88-983e-8ca95098cd9b"), 50m, "Delivered", new DateTime(2024, 5, 24, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9280), 1000m, 950m, "Credit", new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9288), new Guid("6d5f444d-81b4-431b-be87-19a40ecdb057") },
                    { new Guid("a9582e25-ac8e-4993-a05c-f52baf655d09"), "B4", null, new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9309), new Guid("44e439a3-e71f-4ade-9ffe-2d14b605f7ec"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9307), new DateTime(2024, 5, 25, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9308), new Guid("eec176ba-59b8-4f0b-9c61-bf00cb3458f4"), true, "Note 4", new DateTime(2024, 5, 23, 10, 8, 25, 447, DateTimeKind.Utc).AddTicks(9310), new Guid("bd803e52-5fcb-41ba-9a6f-f1e5ba2d6d5b"), 200m, "Delivered", new DateTime(2024, 5, 24, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9307), 4000m, 3800m, "Credit", new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9309), new Guid("8b901c31-790a-4970-8f26-7901e5e7b0f9") },
                    { new Guid("c61c9b0c-257f-498e-b68d-dbeefa2cb9c0"), "B5", null, new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9313), new Guid("43c31dbd-d843-4787-9cc4-475b0b06acef"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9312), new DateTime(2024, 5, 25, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9313), new Guid("a83aee0b-c02b-4f24-948d-a0e069d8007d"), true, "Note 5", new DateTime(2024, 5, 23, 10, 8, 25, 447, DateTimeKind.Utc).AddTicks(9314), new Guid("e204da23-bb6e-4167-a173-9f81da978195"), 250m, "Delivered", new DateTime(2024, 5, 24, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9312), 5000m, 4750m, "Credit", new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9314), new Guid("9b623cda-dfe9-4f91-bfdd-f823836c9c15") }
                });

            migrationBuilder.InsertData(
                table: "ShoesDetails_Sizes",
                columns: new[] { "ID", "Quantity", "ShoesDetailsID", "SizeID" },
                values: new object[,]
                {
                    { new Guid("29a027a1-8b3e-473e-825a-ddec6adf3f96"), 40, new Guid("fc4c7431-458d-4dd9-a0ed-493a1cef8a38"), new Guid("babcd2bb-4040-4082-8552-2e3af478802b") },
                    { new Guid("4a267411-3750-43de-b466-f0dcbb8fd807"), 10, new Guid("49e886b2-4517-49c9-a22a-0c9468994f61"), new Guid("2d1c4cf3-feb9-429b-abfb-0fb37700194c") },
                    { new Guid("7d932b9b-2088-44ce-89fd-8658bf7ef3db"), 30, new Guid("4e934ca4-e7cd-49db-ae2b-d587d786a847"), new Guid("d849bd09-0183-4e6e-8ef8-7fe85b06000a") },
                    { new Guid("a6f29bf2-35be-4983-ae36-41eeee344852"), 20, new Guid("e35d9c32-839a-4234-8e57-a7cc3d4bfd63"), new Guid("10c098fc-0c8d-46b4-a91c-ee9858959ae2") },
                    { new Guid("c002c7e9-3777-4c9f-98ef-39570dfb10df"), 50, new Guid("274b28ab-d6f0-4a56-8dcf-fa7cbe1cb2c8"), new Guid("612836b0-f6c5-4cd5-b141-8c90b638d3c3") }
                });

            migrationBuilder.InsertData(
                table: "BillDetails",
                columns: new[] { "ID", "BillID", "Price", "Quantity", "ShoesDetails_SizeID", "Status" },
                values: new object[,]
                {
                    { new Guid("108832fd-2b54-4592-b287-a15ec79474db"), new Guid("350d9f52-717f-413e-8b1a-35d68e6c5703"), 3000m, 3, new Guid("7c6cc892-28ef-4a0c-a96b-dba029b9f328"), "Delivered" },
                    { new Guid("39fbfb26-de26-4fe1-a1ad-67ca088a710c"), new Guid("c61c9b0c-257f-498e-b68d-dbeefa2cb9c0"), 5000m, 5, new Guid("2f03164b-20f5-4901-a6ae-1bc758150fff"), "Delivered" },
                    { new Guid("4bcff043-25e6-4ab3-8471-dc0fb25ab038"), new Guid("a9582e25-ac8e-4993-a05c-f52baf655d09"), 4000m, 4, new Guid("f0f7837f-89f8-4c02-b8f8-e534aa09669d"), "Delivered" },
                    { new Guid("9fc42096-9235-4995-aebd-9ca37b46a607"), new Guid("2d41d790-a11a-4e9f-bcd9-1fe446d55632"), 2000m, 2, new Guid("9ec60464-9a60-4067-9f69-3461bbd80290"), "Delivered" },
                    { new Guid("e14d4039-81be-4a4d-824b-2bffa6dc7bfc"), new Guid("845d90bc-8661-4e3e-8f5d-1c6ad82d564b"), 1000m, 1, new Guid("96505997-d98b-428b-b9a8-dd551913bed8"), "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "BillStatusHistories",
                columns: new[] { "BillStatusHistoryID", "BillID", "ChangeDate", "Note", "Status" },
                values: new object[,]
                {
                    { new Guid("4728fe6d-21bf-44a1-8a31-ef24f1b6b8c6"), new Guid("a9582e25-ac8e-4993-a05c-f52baf655d09"), new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9460), "Order delivered", "Delivered" },
                    { new Guid("498bed47-7824-42ff-94e8-0311b8eae461"), new Guid("a9582e25-ac8e-4993-a05c-f52baf655d09"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9456), "Order placed", "Ordered" },
                    { new Guid("4d6d8b91-73d9-48fd-be98-24d18efc271b"), new Guid("c61c9b0c-257f-498e-b68d-dbeefa2cb9c0"), new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9465), "Order delivered", "Delivered" },
                    { new Guid("63ca7a85-6d94-4cb4-9c3b-8b9bcf21ce52"), new Guid("350d9f52-717f-413e-8b1a-35d68e6c5703"), new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9396), "Order shipped", "Shipped" },
                    { new Guid("65a65e2e-7163-496d-9f2a-1c0f8302b42b"), new Guid("2d41d790-a11a-4e9f-bcd9-1fe446d55632"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9387), "Order placed", "Ordered" },
                    { new Guid("89b69b59-9b76-4266-bc34-92882af25891"), new Guid("845d90bc-8661-4e3e-8f5d-1c6ad82d564b"), new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9383), "Order shipped", "Shipped" },
                    { new Guid("8b69e7fc-cc6f-4f73-8ef1-826aa9ac6994"), new Guid("845d90bc-8661-4e3e-8f5d-1c6ad82d564b"), new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9385), "Order delivered", "Delivered" },
                    { new Guid("933953e3-4e81-4177-8728-15bc6bacfeef"), new Guid("c61c9b0c-257f-498e-b68d-dbeefa2cb9c0"), new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9463), "Order shipped", "Shipped" },
                    { new Guid("a3a22577-e2c1-439a-ad82-9e0fd6778acc"), new Guid("2d41d790-a11a-4e9f-bcd9-1fe446d55632"), new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9389), "Order shipped", "Shipped" },
                    { new Guid("c775dbe5-bf8c-46f3-a3d3-8db5b64baef4"), new Guid("2d41d790-a11a-4e9f-bcd9-1fe446d55632"), new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9391), "Order delivered", "Delivered" },
                    { new Guid("cc63b8a9-bf65-4552-9a75-46ec64549b1f"), new Guid("845d90bc-8661-4e3e-8f5d-1c6ad82d564b"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9379), "Order placed", "Ordered" },
                    { new Guid("d6b59a3e-7b9e-44e6-bb80-24471177e488"), new Guid("c61c9b0c-257f-498e-b68d-dbeefa2cb9c0"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9461), "Order placed", "Ordered" },
                    { new Guid("f0dfc023-fbb8-4b54-a67f-26d1a31242a6"), new Guid("350d9f52-717f-413e-8b1a-35d68e6c5703"), new DateTime(2024, 5, 23, 9, 8, 25, 447, DateTimeKind.Utc).AddTicks(9398), "Order delivered", "Delivered" },
                    { new Guid("fd9c417a-fda3-42e7-b2b8-ee4717acaf25"), new Guid("a9582e25-ac8e-4993-a05c-f52baf655d09"), new DateTime(2024, 5, 23, 8, 8, 25, 447, DateTimeKind.Utc).AddTicks(9458), "Order shipped", "Shipped" },
                    { new Guid("feff2b5b-439e-44c0-8b5c-b0cae46e5fbb"), new Guid("350d9f52-717f-413e-8b1a-35d68e6c5703"), new DateTime(2024, 5, 23, 7, 8, 25, 447, DateTimeKind.Utc).AddTicks(9393), "Order placed", "Ordered" }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "ID", "CartID", "Quantity", "ShoesDetails_SizeID" },
                values: new object[,]
                {
                    { new Guid("94712c23-7d6f-45fc-b780-ac910d58315b"), new Guid("8564a625-bb01-43b5-856a-335aaf039ee1"), 1, new Guid("4a267411-3750-43de-b466-f0dcbb8fd807") },
                    { new Guid("cc0158e1-40a8-4053-98ad-953dab7f20cc"), new Guid("6cb952f1-16af-49b9-b06c-f2ec3d8c003d"), 2, new Guid("a6f29bf2-35be-4983-ae36-41eeee344852") },
                    { new Guid("e56fc914-7b46-4977-b4db-370019daec49"), new Guid("80522396-41a9-4191-8da8-2bee8fb1b318"), 4, new Guid("29a027a1-8b3e-473e-825a-ddec6adf3f96") },
                    { new Guid("ec1ad9f7-f544-46a3-8ff9-9e5602f8aa20"), new Guid("e5e44eb3-92fc-4b9b-8c6e-23eaee77361b"), 3, new Guid("7d932b9b-2088-44ce-89fd-8658bf7ef3db") },
                    { new Guid("f80ae670-00c7-4ba6-8b88-1d91ef8ae2c9"), new Guid("d7af55e8-33ba-41c2-bf17-2bb26a249665"), 5, new Guid("c002c7e9-3777-4c9f-98ef-39570dfb10df") }
                });
        }
    }
}
