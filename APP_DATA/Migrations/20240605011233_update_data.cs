using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class update_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorID", "ColorCode", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("366dd4cf-b080-41f6-9d5e-375ed311f93e"), "C1", new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2898), "Red", "Active" },
                    { new Guid("96e9a776-f491-481f-85ee-c1e59517e3b1"), "C5", new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2908), "Black", "Active" },
                    { new Guid("b394d6d0-0558-47ac-a6af-eb5d98c2b594"), "C2", new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2904), "Blue", "Active" },
                    { new Guid("bfc3354d-8945-4528-94d5-0870352dc9ac"), "C4", new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2907), "Yellow", "Active" },
                    { new Guid("edd6d947-d7fc-41f6-a2ec-eec2f4c743bc"), "C3", new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2906), "Green", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "DateCreated", "Email", "FullName", "Password", "PhoneNumber", "ResetPassword", "Sex", "UserName" },
                values: new object[,]
                {
                    { new Guid("91e73ad1-fcd9-4f66-aabe-cec2a794a217"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2296), "customer4@example.com", "Customer 4", "password", "4321432143", "reset4", "Female", "customer4" },
                    { new Guid("bef74dac-9337-444e-b4fc-ee76f35482ee"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2278), "customer2@example.com", "Customer 2", "password", "0987654321", "reset2", "Female", "customer2" },
                    { new Guid("c9231368-2924-4024-a211-e0264e49485f"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2271), "customer1@example.com", "Customer 1", "password", "1234567890", "reset1", "Male", "customer1" },
                    { new Guid("d0b88215-17b1-4e2a-9a8e-b44fea3c9ba2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2294), "customer3@example.com", "Customer 3", "password", "1231231234", "reset3", "Male", "customer3" },
                    { new Guid("f5a02a83-4204-4a63-b5d0-a4c6f917037c"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2298), "customer5@example.com", "Customer 5", "password", "6789678967", "reset5", "Male", "customer5" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageID", "DateCreated", "ImageCode", "ImageUrl1", "ImageUrl2", "ImageUrl3", "ImageUrl4", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("873abab9-58e5-424a-ba7c-7d2fd36dd0aa"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3024), "IMG2", "https://example.com/img2_1.jpg", "https://example.com/img2_2.jpg", "https://example.com/img2_3.jpg", "https://example.com/img2_4.jpg", "Image 2", "Active" },
                    { new Guid("b8ec9c22-6562-466a-952c-c4f011a47301"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3029), "IMG4", "https://example.com/img4_1.jpg", "https://example.com/img4_2.jpg", "https://example.com/img4_3.jpg", "https://example.com/img4_4.jpg", "Image 4", "Active" },
                    { new Guid("d33ae07a-049a-4a2c-bd4e-aa1d475d1226"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3028), "IMG3", "https://example.com/img3_1.jpg", "https://example.com/img3_2.jpg", "https://example.com/img3_3.jpg", "https://example.com/img3_4.jpg", "Image 3", "Active" },
                    { new Guid("deca544d-c83d-4983-9cf4-19101e3a6a90"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3031), "IMG5", "https://example.com/img5_1.jpg", "https://example.com/img5_2.jpg", "https://example.com/img5_3.jpg", "https://example.com/img5_4.jpg", "Image 5", "Active" },
                    { new Guid("fcbd3ee1-7502-4dec-9582-959d690caef2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2980), "IMG1", "https://example.com/img1_1.jpg", "https://example.com/img1_2.jpg", "https://example.com/img1_3.jpg", "https://example.com/img1_4.jpg", "Image 1", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialID", "DateCreated", "MaterialCode", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("55cbdc6e-4f0a-49e3-91ee-e250cdf42e0b"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2928), "M1", "Leather", "Active" },
                    { new Guid("61177342-4b17-40b4-9380-4db50753888c"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2932), "M3", "Canvas", "Active" },
                    { new Guid("7d16bcc6-a568-4ed0-8cb1-e387c068ad18"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2931), "M2", "Suede", "Active" },
                    { new Guid("d4ae2c71-1141-4b77-bb2a-0b084ed103d8"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2934), "M4", "Synthetic", "Active" },
                    { new Guid("f74a4cd7-0df1-4e39-8bfd-11bfc045feed"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2937), "M5", "Rubber", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "DateCreated", "Name", "ProductCode", "Status" },
                values: new object[,]
                {
                    { new Guid("43be6cc6-6906-438c-a7ef-5e8eaef18db5"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2958), "Sneakers", "P2", "Active" },
                    { new Guid("8df85c27-5d9e-4f22-a5ca-127973a88470"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2955), "Running Shoes", "P1", "Active" },
                    { new Guid("9df703c7-4ad9-4c54-ab8d-e1edf7de1265"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2962), "Formal Shoes", "P5", "Active" },
                    { new Guid("bef6e269-4f9d-4797-be82-3f3f180e6675"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2961), "Sandals", "P4", "Active" },
                    { new Guid("f7db9156-edd6-44da-8b0a-6c811bc423c3"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2960), "Boots", "P3", "Active" }
                });

            migrationBuilder.InsertData(
                table: "PurchaseMethods",
                columns: new[] { "PurchaseMethodID", "DateCreated", "Name", "Status" },
                values: new object[,]
                {
                    { new Guid("4c287058-da8f-4b22-ab4f-ef9de9a65ba3"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2619), "Cash", "Active" },
                    { new Guid("63ffbd99-6114-4456-8d09-30e8e7da5da9"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2611), "Credit Card", "Active" },
                    { new Guid("c535c31c-1667-4150-9101-d6ca1a7de1b2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2621), "Cryptocurrency", "Active" },
                    { new Guid("d73a6430-cabd-467e-9823-9a5775d8cb90"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2617), "PayPal", "Active" },
                    { new Guid("ea6b6cf4-f70f-43eb-b16c-ee8af629a4e2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2620), "Bank Transfer", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "DateCreated", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("73c3b223-e3da-41fd-9fdd-c1ee936bd11c"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2509), "R3", "Manager" },
                    { new Guid("83656ebf-cb23-40f1-b799-07f5c5ff2cd6"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2507), "R2", "User" },
                    { new Guid("8454b86c-350e-4a64-80d2-1d29046edd74"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2504), "R1", "Admin" },
                    { new Guid("b65ce917-48dc-4c0f-99c8-2173325e4875"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2510), "R4", "Support" },
                    { new Guid("c7f110d9-6100-4746-8e43-0cf6a0a585cd"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2512), "R5", "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Sexes",
                columns: new[] { "SexID", "SexName" },
                values: new object[,]
                {
                    { new Guid("0bd6c9d8-f71a-45c7-bfc6-5b9de912d455"), "Unisex" },
                    { new Guid("cdd94718-8334-4b0d-9389-1aeff7cb636e"), "Female" },
                    { new Guid("dba9292a-027a-4768-a8cc-ec3dba8a2730"), "Others" },
                    { new Guid("eb5e5097-0e86-4fde-aee4-a44676ac0eac"), "Male" },
                    { new Guid("ee81a1ad-d4a7-4e16-bf27-203de5a36c04"), "Kids" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("43ce3c11-3460-47c0-9d39-6eecc91df2d8"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2873), "Size 2", "S2", "Active" },
                    { new Guid("7fe21232-1a38-4538-b40e-67fa9d32679f"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2871), "Size 1", "S1", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeID", "DateCreated", "Name", "SizeCode", "Status" },
                values: new object[,]
                {
                    { new Guid("8d9396ea-e324-468c-8285-f3c3456db3a9"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2875), "Size 3", "S3", "Active" },
                    { new Guid("945d3a5d-2134-4795-830b-227d483d44a4"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2876), "Size 4", "S4", "Active" },
                    { new Guid("a575432e-143a-41c0-9cf8-f2bca64b2c07"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2878), "Size 5", "S5", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Styles",
                columns: new[] { "StyleID", "DateCreated", "Name", "Status", "StyleCode" },
                values: new object[,]
                {
                    { new Guid("02c60d54-e63c-454b-89ab-29c850d663da"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3077), "Casual", "Active", "ST1" },
                    { new Guid("21994e18-7740-45f3-88cb-c0be1d88365f"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3083), "Outdoor", "Active", "ST4" },
                    { new Guid("8ab3d8aa-4aae-4084-8eda-876a03217485"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3080), "Sport", "Active", "ST2" },
                    { new Guid("90ea5bda-8368-42da-87be-341a43012742"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3082), "Formal", "Active", "ST3" },
                    { new Guid("a9554b2b-1442-481a-931d-8497e668a5fc"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(3084), "Work", "Active", "ST5" }
                });

            migrationBuilder.InsertData(
                table: "Vouchers",
                columns: new[] { "VoucherID", "DateCreated", "ExpirationDate", "MaxUsage", "RemainingUsage", "Status", "Total", "VoucherCode", "VoucherValue" },
                values: new object[,]
                {
                    { new Guid("0beb4994-ad46-4538-aeda-84e458728137"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 7, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2580), 10m, 2m, true, 1000, "VC4", 400m },
                    { new Guid("760f291c-18fc-43e7-8003-76017c0b7443"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 7, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2566), 10m, 5m, true, 1000, "VC1", 100m },
                    { new Guid("7c3cd40e-aca2-4606-b986-634c317ac3c2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 7, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2582), 10m, 1m, true, 1000, "VC5", 500m },
                    { new Guid("a7fc6d1a-73a8-4ca7-8aef-700a7ae580c2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2575), new DateTime(2024, 7, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2575), 10m, 4m, true, 1000, "VC2", 200m },
                    { new Guid("ede269c5-9ec7-4fd8-b7ea-20ddd58a9c11"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 7, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2578), 10m, 3m, true, 1000, "VC3", 300m }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "Commune", "CustomerID", "DateCreated", "District", "DistrictCode", "IsDefaultAddress", "Province", "ShippingCost", "Status", "Street", "WardCode" },
                values: new object[,]
                {
                    { new Guid("3218db13-6288-4ad5-a044-4f0619b080ed"), "Commune 5", new Guid("f5a02a83-4204-4a63-b5d0-a4c6f917037c"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2437), "District 5", "D5", true, "Province 5", 50m, "Active", "Street 5", "W5" },
                    { new Guid("387d3dce-508c-4afb-b594-ddfd7e05c716"), "Commune 3", new Guid("d0b88215-17b1-4e2a-9a8e-b44fea3c9ba2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2432), "District 3", "D3", true, "Province 3", 30m, "Active", "Street 3", "W3" },
                    { new Guid("88b30c80-31e7-43bd-afdc-7d4041e3ddbe"), "Commune 4", new Guid("91e73ad1-fcd9-4f66-aabe-cec2a794a217"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2434), "District 4", "D4", false, "Province 4", 40m, "Active", "Street 4", "W4" },
                    { new Guid("9b4e4820-7776-49d9-b157-d90b6daaf474"), "Commune 1", new Guid("c9231368-2924-4024-a211-e0264e49485f"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2422), "District 1", "D1", true, "Province 1", 10m, "Active", "Street 1", "W1" },
                    { new Guid("f465847b-e4ed-4e4e-856c-370bc77b4425"), "Commune 2", new Guid("bef74dac-9337-444e-b4fc-ee76f35482ee"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2430), "District 2", "D2", false, "Province 2", 20m, "Active", "Street 2", "W2" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartID", "CustomerID" },
                values: new object[,]
                {
                    { new Guid("124fa20b-01ad-49a9-bd10-ecfafedff1af"), new Guid("d0b88215-17b1-4e2a-9a8e-b44fea3c9ba2") },
                    { new Guid("19a5f8e4-87aa-40d0-9dc3-2461ca8a0e0e"), new Guid("bef74dac-9337-444e-b4fc-ee76f35482ee") },
                    { new Guid("1dc964cf-d7cb-45cd-8cda-49c6c8cb3dc8"), new Guid("c9231368-2924-4024-a211-e0264e49485f") },
                    { new Guid("5073baf0-3700-4449-a822-0e8a1274e295"), new Guid("f5a02a83-4204-4a63-b5d0-a4c6f917037c") },
                    { new Guid("ade85f8e-85cc-4508-b66f-0c5f46135a9e"), new Guid("91e73ad1-fcd9-4f66-aabe-cec2a794a217") }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "DateCreated", "Email", "FullName", "IdentificationCode", "Image", "Password", "PhoneNumber", "RoleID", "Sex", "Status", "UserName" },
                values: new object[,]
                {
                    { new Guid("242f004a-6325-47a5-a199-c3ed7cfa1876"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2546), "employee5@example.com", "Employee 5", "ID5", "img5.png", "password", "6789678967", new Guid("c7f110d9-6100-4746-8e43-0cf6a0a585cd"), "Male", "Active", "employee5" },
                    { new Guid("2927eaba-ba0c-45b2-bc94-b9dbee3ffc3d"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2537), "employee2@example.com", "Employee 2", "ID2", "img2.png", "password", "0987654321", new Guid("83656ebf-cb23-40f1-b799-07f5c5ff2cd6"), "Female", "Active", "employee2" },
                    { new Guid("4a20b2c6-bcc3-4895-aaa6-e6b8722eef2a"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2533), "employee1@example.com", "Employee 1", "ID1", "img1.png", "password", "1234567890", new Guid("8454b86c-350e-4a64-80d2-1d29046edd74"), "Male", "Active", "employee1" },
                    { new Guid("b5d6a8d3-cd61-474b-ac2b-4d3ebce0c3f6"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2544), "employee4@example.com", "Employee 4", "ID4", "img4.png", "password", "4321432143", new Guid("b65ce917-48dc-4c0f-99c8-2173325e4875"), "Female", "Active", "employee4" },
                    { new Guid("ff0f6820-f98d-49e4-81b3-47dc433f4719"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2539), "employee3@example.com", "Employee 3", "ID3", "img3.png", "password", "1231231234", new Guid("73c3b223-e3da-41fd-9fdd-c1ee936bd11c"), "Male", "Active", "employee3" }
                });

            migrationBuilder.InsertData(
                table: "ShoesDetails",
                columns: new[] { "ShoesDetailsID", "ColorID", "Description", "ImageID", "MaterialID", "Price", "ProductID", "SexID", "ShoesDetailsCode", "SizeID", "Status", "StyleID" },
                values: new object[,]
                {
                    { new Guid("06dd3e89-9c22-4e83-942c-e0f6530cb942"), new Guid("96e9a776-f491-481f-85ee-c1e59517e3b1"), "Formal Shoes", new Guid("deca544d-c83d-4983-9cf4-19101e3a6a90"), new Guid("f74a4cd7-0df1-4e39-8bfd-11bfc045feed"), 5000m, new Guid("9df703c7-4ad9-4c54-ab8d-e1edf7de1265"), new Guid("dba9292a-027a-4768-a8cc-ec3dba8a2730"), "SD5", new Guid("7fe21232-1a38-4538-b40e-67fa9d32679f"), "Active", new Guid("a9554b2b-1442-481a-931d-8497e668a5fc") },
                    { new Guid("31836984-3951-4408-8662-ba8e45a7c580"), new Guid("bfc3354d-8945-4528-94d5-0870352dc9ac"), "Sandals", new Guid("b8ec9c22-6562-466a-952c-c4f011a47301"), new Guid("d4ae2c71-1141-4b77-bb2a-0b084ed103d8"), 4000m, new Guid("bef6e269-4f9d-4797-be82-3f3f180e6675"), new Guid("ee81a1ad-d4a7-4e16-bf27-203de5a36c04"), "SD4", new Guid("7fe21232-1a38-4538-b40e-67fa9d32679f"), "Active", new Guid("21994e18-7740-45f3-88cb-c0be1d88365f") },
                    { new Guid("410fc8bd-046e-4357-b81f-309d86d43292"), new Guid("b394d6d0-0558-47ac-a6af-eb5d98c2b594"), "Sneakers", new Guid("873abab9-58e5-424a-ba7c-7d2fd36dd0aa"), new Guid("7d16bcc6-a568-4ed0-8cb1-e387c068ad18"), 2000m, new Guid("43be6cc6-6906-438c-a7ef-5e8eaef18db5"), new Guid("cdd94718-8334-4b0d-9389-1aeff7cb636e"), "SD2", new Guid("7fe21232-1a38-4538-b40e-67fa9d32679f"), "Active", new Guid("8ab3d8aa-4aae-4084-8eda-876a03217485") },
                    { new Guid("45a2e68d-b11e-424a-96fa-c015542509c4"), new Guid("edd6d947-d7fc-41f6-a2ec-eec2f4c743bc"), "Boots", new Guid("d33ae07a-049a-4a2c-bd4e-aa1d475d1226"), new Guid("61177342-4b17-40b4-9380-4db50753888c"), 3000m, new Guid("f7db9156-edd6-44da-8b0a-6c811bc423c3"), new Guid("0bd6c9d8-f71a-45c7-bfc6-5b9de912d455"), "SD3", new Guid("7fe21232-1a38-4538-b40e-67fa9d32679f"), "Active", new Guid("90ea5bda-8368-42da-87be-341a43012742") },
                    { new Guid("e4289651-e7dd-4ca4-885d-ea4db2a76b17"), new Guid("366dd4cf-b080-41f6-9d5e-375ed311f93e"), "Running Shoes", new Guid("fcbd3ee1-7502-4dec-9582-959d690caef2"), new Guid("55cbdc6e-4f0a-49e3-91ee-e250cdf42e0b"), 1000m, new Guid("8df85c27-5d9e-4f22-a5ca-127973a88470"), new Guid("eb5e5097-0e86-4fde-aee4-a44676ac0eac"), "SD1", new Guid("7fe21232-1a38-4538-b40e-67fa9d32679f"), "Active", new Guid("02c60d54-e63c-454b-89ab-29c850d663da") }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "ID", "BillCode", "CancelDate", "ConfirmationDate", "CustomerID", "DateCreated", "DeliveryDate", "EmployeeID", "IsPaid", "Note", "PaymentDay", "PurchaseMethodID", "ShippingCosts", "Status", "SuccessDate", "TotalPrice", "TotalPriceAfterDiscount", "TransactionType", "UpdateDate", "VoucherID" },
                values: new object[,]
                {
                    { new Guid("07a4ba96-a8f1-4f6d-a90a-67121811a352"), "B4", null, new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2743), new Guid("91e73ad1-fcd9-4f66-aabe-cec2a794a217"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2741), new DateTime(2024, 6, 7, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2742), new Guid("b5d6a8d3-cd61-474b-ac2b-4d3ebce0c3f6"), true, "Note 4", new DateTime(2024, 6, 5, 4, 12, 33, 23, DateTimeKind.Utc).AddTicks(2744), new Guid("ea6b6cf4-f70f-43eb-b16c-ee8af629a4e2"), 200m, "Delivered", new DateTime(2024, 6, 6, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2741), 4000m, 3800m, "Credit", new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2743), new Guid("0beb4994-ad46-4538-aeda-84e458728137") },
                    { new Guid("2c25177d-8288-47e3-b348-a729eb8b1f11"), "B2", null, new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2659), new Guid("bef74dac-9337-444e-b4fc-ee76f35482ee"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2657), new DateTime(2024, 6, 7, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2658), new Guid("2927eaba-ba0c-45b2-bc94-b9dbee3ffc3d"), true, "Note 2", new DateTime(2024, 6, 5, 4, 12, 33, 23, DateTimeKind.Utc).AddTicks(2661), new Guid("d73a6430-cabd-467e-9823-9a5775d8cb90"), 100m, "Delivered", new DateTime(2024, 6, 6, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2657), 2000m, 1900m, "Credit", new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2661), new Guid("a7fc6d1a-73a8-4ca7-8aef-700a7ae580c2") },
                    { new Guid("47aca5a4-c97b-4cff-99c3-713290d6dd1f"), "B1", null, new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2651), new Guid("c9231368-2924-4024-a211-e0264e49485f"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2642), new DateTime(2024, 6, 7, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2649), new Guid("4a20b2c6-bcc3-4895-aaa6-e6b8722eef2a"), true, "Note 1", new DateTime(2024, 6, 5, 4, 12, 33, 23, DateTimeKind.Utc).AddTicks(2652), new Guid("63ffbd99-6114-4456-8d09-30e8e7da5da9"), 50m, "Delivered", new DateTime(2024, 6, 6, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2643), 1000m, 950m, "Credit", new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2651), new Guid("760f291c-18fc-43e7-8003-76017c0b7443") },
                    { new Guid("a4fb7a9e-0d59-4f93-a464-a9e0ca867c7c"), "B3", null, new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2736), new Guid("d0b88215-17b1-4e2a-9a8e-b44fea3c9ba2"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2734), new DateTime(2024, 6, 7, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2735), new Guid("ff0f6820-f98d-49e4-81b3-47dc433f4719"), true, "Note 3", new DateTime(2024, 6, 5, 4, 12, 33, 23, DateTimeKind.Utc).AddTicks(2738), new Guid("4c287058-da8f-4b22-ab4f-ef9de9a65ba3"), 150m, "Delivered", new DateTime(2024, 6, 6, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2735), 3000m, 2850m, "Credit", new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2737), new Guid("ede269c5-9ec7-4fd8-b7ea-20ddd58a9c11") },
                    { new Guid("d8a7681a-1420-49af-b2e7-6d3f69a2016d"), "B5", null, new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2750), new Guid("f5a02a83-4204-4a63-b5d0-a4c6f917037c"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 6, 7, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2749), new Guid("242f004a-6325-47a5-a199-c3ed7cfa1876"), true, "Note 5", new DateTime(2024, 6, 5, 4, 12, 33, 23, DateTimeKind.Utc).AddTicks(2751), new Guid("c535c31c-1667-4150-9101-d6ca1a7de1b2"), 250m, "Delivered", new DateTime(2024, 6, 6, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2749), 5000m, 4750m, "Credit", new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2751), new Guid("7c3cd40e-aca2-4606-b986-634c317ac3c2") }
                });

            migrationBuilder.InsertData(
                table: "CartDetails",
                columns: new[] { "ID", "CartID", "Quantity", "ShoeDetailsID" },
                values: new object[,]
                {
                    { new Guid("07068c88-ae2d-4157-88f0-cbc2c35980c9"), new Guid("5073baf0-3700-4449-a822-0e8a1274e295"), 5, new Guid("06dd3e89-9c22-4e83-942c-e0f6530cb942") },
                    { new Guid("3233b48c-720f-4223-81f7-1fbdb795dca8"), new Guid("ade85f8e-85cc-4508-b66f-0c5f46135a9e"), 4, new Guid("31836984-3951-4408-8662-ba8e45a7c580") },
                    { new Guid("3270499a-40ad-4850-ab76-7a4baf98a59a"), new Guid("124fa20b-01ad-49a9-bd10-ecfafedff1af"), 3, new Guid("45a2e68d-b11e-424a-96fa-c015542509c4") },
                    { new Guid("39216fb8-7d44-487a-bf9f-f2733059245b"), new Guid("19a5f8e4-87aa-40d0-9dc3-2461ca8a0e0e"), 2, new Guid("410fc8bd-046e-4357-b81f-309d86d43292") },
                    { new Guid("fd695391-1bec-45f8-9568-70a9358488bd"), new Guid("1dc964cf-d7cb-45cd-8cda-49c6c8cb3dc8"), 1, new Guid("e4289651-e7dd-4ca4-885d-ea4db2a76b17") }
                });

            migrationBuilder.InsertData(
                table: "BillDetails",
                columns: new[] { "ID", "BillID", "Price", "Quantity", "ShoesDetails_SizeID", "Status" },
                values: new object[,]
                {
                    { new Guid("2942f63e-dd04-434c-9446-2e03d8f0c82f"), new Guid("2c25177d-8288-47e3-b348-a729eb8b1f11"), 2000m, 2, new Guid("4da57313-abe4-41cb-ab44-d56293fc16ce"), "Delivered" },
                    { new Guid("4a0e2b02-5283-4746-a006-ae17c4312a1c"), new Guid("d8a7681a-1420-49af-b2e7-6d3f69a2016d"), 5000m, 5, new Guid("1a5c94b1-2935-4920-baed-493a8bf550c5"), "Delivered" },
                    { new Guid("7b114f79-adce-4d33-a5e3-d356afd76735"), new Guid("47aca5a4-c97b-4cff-99c3-713290d6dd1f"), 1000m, 1, new Guid("5dec446d-6b9b-4a7e-894b-1191fde5ecf5"), "Delivered" },
                    { new Guid("bfc5c581-8825-4ca1-912e-abf06146e990"), new Guid("a4fb7a9e-0d59-4f93-a464-a9e0ca867c7c"), 3000m, 3, new Guid("1d7bd185-36db-4081-a1ef-7bd592ad05be"), "Delivered" },
                    { new Guid("c5f25db5-09d2-4e21-8f51-1193d134cc91"), new Guid("07a4ba96-a8f1-4f6d-a90a-67121811a352"), 4000m, 4, new Guid("0eddb26e-242a-4df0-89b9-b9f6195f6179"), "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "BillStatusHistories",
                columns: new[] { "BillStatusHistoryID", "BillID", "ChangeDate", "Note", "Status" },
                values: new object[,]
                {
                    { new Guid("0c8b7c6c-d1da-4602-bffd-f052d384313d"), new Guid("a4fb7a9e-0d59-4f93-a464-a9e0ca867c7c"), new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2832), "Order shipped", "Shipped" },
                    { new Guid("0dd5b086-5dd1-403b-93fb-55c7b8a8d9f6"), new Guid("a4fb7a9e-0d59-4f93-a464-a9e0ca867c7c"), new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2834), "Order delivered", "Delivered" },
                    { new Guid("22822d7b-4aa6-4597-a006-821792dcecc9"), new Guid("2c25177d-8288-47e3-b348-a729eb8b1f11"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2823), "Order placed", "Ordered" },
                    { new Guid("266c4728-1506-48e6-b159-602c95fce2a3"), new Guid("d8a7681a-1420-49af-b2e7-6d3f69a2016d"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2841), "Order placed", "Ordered" },
                    { new Guid("2da005b3-14ac-4dd1-86ad-94f171d08ab5"), new Guid("47aca5a4-c97b-4cff-99c3-713290d6dd1f"), new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2821), "Order delivered", "Delivered" },
                    { new Guid("4078401b-828d-4ee3-98f1-7d2926acd964"), new Guid("47aca5a4-c97b-4cff-99c3-713290d6dd1f"), new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2818), "Order shipped", "Shipped" },
                    { new Guid("478d8a02-dd1c-4bed-ad81-0954a04765a3"), new Guid("07a4ba96-a8f1-4f6d-a90a-67121811a352"), new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2838), "Order shipped", "Shipped" },
                    { new Guid("5bf80213-2f98-4de1-b9a1-650f7b536ed2"), new Guid("07a4ba96-a8f1-4f6d-a90a-67121811a352"), new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2840), "Order delivered", "Delivered" },
                    { new Guid("6cf45ef2-840c-4065-9657-5c3c067f4ae4"), new Guid("2c25177d-8288-47e3-b348-a729eb8b1f11"), new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2829), "Order delivered", "Delivered" },
                    { new Guid("720e6e21-f472-44e8-8abd-eeadbefbfc01"), new Guid("d8a7681a-1420-49af-b2e7-6d3f69a2016d"), new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2845), "Order shipped", "Shipped" },
                    { new Guid("74d483e4-ad30-4dff-8ebb-d7bf958d936e"), new Guid("07a4ba96-a8f1-4f6d-a90a-67121811a352"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2836), "Order placed", "Ordered" },
                    { new Guid("7d95087a-f636-4c7b-928a-22dbd323ea2e"), new Guid("2c25177d-8288-47e3-b348-a729eb8b1f11"), new DateTime(2024, 6, 5, 2, 12, 33, 23, DateTimeKind.Utc).AddTicks(2825), "Order shipped", "Shipped" },
                    { new Guid("acc7b7c8-d6a3-474a-a03d-69d7efce7f06"), new Guid("d8a7681a-1420-49af-b2e7-6d3f69a2016d"), new DateTime(2024, 6, 5, 3, 12, 33, 23, DateTimeKind.Utc).AddTicks(2847), "Order delivered", "Delivered" },
                    { new Guid("ace05400-f24e-49a0-92fd-a1a5fdc35b71"), new Guid("a4fb7a9e-0d59-4f93-a464-a9e0ca867c7c"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2831), "Order placed", "Ordered" },
                    { new Guid("f02dfc74-99b5-447f-b208-b1f8099d0d58"), new Guid("47aca5a4-c97b-4cff-99c3-713290d6dd1f"), new DateTime(2024, 6, 5, 1, 12, 33, 23, DateTimeKind.Utc).AddTicks(2815), "Order placed", "Ordered" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("3218db13-6288-4ad5-a044-4f0619b080ed"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("387d3dce-508c-4afb-b594-ddfd7e05c716"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("88b30c80-31e7-43bd-afdc-7d4041e3ddbe"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("9b4e4820-7776-49d9-b157-d90b6daaf474"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: new Guid("f465847b-e4ed-4e4e-856c-370bc77b4425"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("2942f63e-dd04-434c-9446-2e03d8f0c82f"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("4a0e2b02-5283-4746-a006-ae17c4312a1c"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("7b114f79-adce-4d33-a5e3-d356afd76735"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("bfc5c581-8825-4ca1-912e-abf06146e990"));

            migrationBuilder.DeleteData(
                table: "BillDetails",
                keyColumn: "ID",
                keyValue: new Guid("c5f25db5-09d2-4e21-8f51-1193d134cc91"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("0c8b7c6c-d1da-4602-bffd-f052d384313d"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("0dd5b086-5dd1-403b-93fb-55c7b8a8d9f6"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("22822d7b-4aa6-4597-a006-821792dcecc9"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("266c4728-1506-48e6-b159-602c95fce2a3"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("2da005b3-14ac-4dd1-86ad-94f171d08ab5"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("4078401b-828d-4ee3-98f1-7d2926acd964"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("478d8a02-dd1c-4bed-ad81-0954a04765a3"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("5bf80213-2f98-4de1-b9a1-650f7b536ed2"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("6cf45ef2-840c-4065-9657-5c3c067f4ae4"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("720e6e21-f472-44e8-8abd-eeadbefbfc01"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("74d483e4-ad30-4dff-8ebb-d7bf958d936e"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("7d95087a-f636-4c7b-928a-22dbd323ea2e"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("acc7b7c8-d6a3-474a-a03d-69d7efce7f06"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("ace05400-f24e-49a0-92fd-a1a5fdc35b71"));

            migrationBuilder.DeleteData(
                table: "BillStatusHistories",
                keyColumn: "BillStatusHistoryID",
                keyValue: new Guid("f02dfc74-99b5-447f-b208-b1f8099d0d58"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("07068c88-ae2d-4157-88f0-cbc2c35980c9"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("3233b48c-720f-4223-81f7-1fbdb795dca8"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("3270499a-40ad-4850-ab76-7a4baf98a59a"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("39216fb8-7d44-487a-bf9f-f2733059245b"));

            migrationBuilder.DeleteData(
                table: "CartDetails",
                keyColumn: "ID",
                keyValue: new Guid("fd695391-1bec-45f8-9568-70a9358488bd"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("43ce3c11-3460-47c0-9d39-6eecc91df2d8"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("8d9396ea-e324-468c-8285-f3c3456db3a9"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("945d3a5d-2134-4795-830b-227d483d44a4"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("a575432e-143a-41c0-9cf8-f2bca64b2c07"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("07a4ba96-a8f1-4f6d-a90a-67121811a352"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("2c25177d-8288-47e3-b348-a729eb8b1f11"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("47aca5a4-c97b-4cff-99c3-713290d6dd1f"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("a4fb7a9e-0d59-4f93-a464-a9e0ca867c7c"));

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "ID",
                keyValue: new Guid("d8a7681a-1420-49af-b2e7-6d3f69a2016d"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("124fa20b-01ad-49a9-bd10-ecfafedff1af"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("19a5f8e4-87aa-40d0-9dc3-2461ca8a0e0e"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("1dc964cf-d7cb-45cd-8cda-49c6c8cb3dc8"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("5073baf0-3700-4449-a822-0e8a1274e295"));

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "CartID",
                keyValue: new Guid("ade85f8e-85cc-4508-b66f-0c5f46135a9e"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("06dd3e89-9c22-4e83-942c-e0f6530cb942"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("31836984-3951-4408-8662-ba8e45a7c580"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("410fc8bd-046e-4357-b81f-309d86d43292"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("45a2e68d-b11e-424a-96fa-c015542509c4"));

            migrationBuilder.DeleteData(
                table: "ShoesDetails",
                keyColumn: "ShoesDetailsID",
                keyValue: new Guid("e4289651-e7dd-4ca4-885d-ea4db2a76b17"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("366dd4cf-b080-41f6-9d5e-375ed311f93e"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("96e9a776-f491-481f-85ee-c1e59517e3b1"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("b394d6d0-0558-47ac-a6af-eb5d98c2b594"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("bfc3354d-8945-4528-94d5-0870352dc9ac"));

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorID",
                keyValue: new Guid("edd6d947-d7fc-41f6-a2ec-eec2f4c743bc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("91e73ad1-fcd9-4f66-aabe-cec2a794a217"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("bef74dac-9337-444e-b4fc-ee76f35482ee"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("c9231368-2924-4024-a211-e0264e49485f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("d0b88215-17b1-4e2a-9a8e-b44fea3c9ba2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: new Guid("f5a02a83-4204-4a63-b5d0-a4c6f917037c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("242f004a-6325-47a5-a199-c3ed7cfa1876"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("2927eaba-ba0c-45b2-bc94-b9dbee3ffc3d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("4a20b2c6-bcc3-4895-aaa6-e6b8722eef2a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("b5d6a8d3-cd61-474b-ac2b-4d3ebce0c3f6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: new Guid("ff0f6820-f98d-49e4-81b3-47dc433f4719"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("873abab9-58e5-424a-ba7c-7d2fd36dd0aa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("b8ec9c22-6562-466a-952c-c4f011a47301"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("d33ae07a-049a-4a2c-bd4e-aa1d475d1226"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("deca544d-c83d-4983-9cf4-19101e3a6a90"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageID",
                keyValue: new Guid("fcbd3ee1-7502-4dec-9582-959d690caef2"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("55cbdc6e-4f0a-49e3-91ee-e250cdf42e0b"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("61177342-4b17-40b4-9380-4db50753888c"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("7d16bcc6-a568-4ed0-8cb1-e387c068ad18"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("d4ae2c71-1141-4b77-bb2a-0b084ed103d8"));

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: new Guid("f74a4cd7-0df1-4e39-8bfd-11bfc045feed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("43be6cc6-6906-438c-a7ef-5e8eaef18db5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("8df85c27-5d9e-4f22-a5ca-127973a88470"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("9df703c7-4ad9-4c54-ab8d-e1edf7de1265"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("bef6e269-4f9d-4797-be82-3f3f180e6675"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: new Guid("f7db9156-edd6-44da-8b0a-6c811bc423c3"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("4c287058-da8f-4b22-ab4f-ef9de9a65ba3"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("63ffbd99-6114-4456-8d09-30e8e7da5da9"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("c535c31c-1667-4150-9101-d6ca1a7de1b2"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("d73a6430-cabd-467e-9823-9a5775d8cb90"));

            migrationBuilder.DeleteData(
                table: "PurchaseMethods",
                keyColumn: "PurchaseMethodID",
                keyValue: new Guid("ea6b6cf4-f70f-43eb-b16c-ee8af629a4e2"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("0bd6c9d8-f71a-45c7-bfc6-5b9de912d455"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("cdd94718-8334-4b0d-9389-1aeff7cb636e"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("dba9292a-027a-4768-a8cc-ec3dba8a2730"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("eb5e5097-0e86-4fde-aee4-a44676ac0eac"));

            migrationBuilder.DeleteData(
                table: "Sexes",
                keyColumn: "SexID",
                keyValue: new Guid("ee81a1ad-d4a7-4e16-bf27-203de5a36c04"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeID",
                keyValue: new Guid("7fe21232-1a38-4538-b40e-67fa9d32679f"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("02c60d54-e63c-454b-89ab-29c850d663da"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("21994e18-7740-45f3-88cb-c0be1d88365f"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("8ab3d8aa-4aae-4084-8eda-876a03217485"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("90ea5bda-8368-42da-87be-341a43012742"));

            migrationBuilder.DeleteData(
                table: "Styles",
                keyColumn: "StyleID",
                keyValue: new Guid("a9554b2b-1442-481a-931d-8497e668a5fc"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("0beb4994-ad46-4538-aeda-84e458728137"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("760f291c-18fc-43e7-8003-76017c0b7443"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("7c3cd40e-aca2-4606-b986-634c317ac3c2"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("a7fc6d1a-73a8-4ca7-8aef-700a7ae580c2"));

            migrationBuilder.DeleteData(
                table: "Vouchers",
                keyColumn: "VoucherID",
                keyValue: new Guid("ede269c5-9ec7-4fd8-b7ea-20ddd58a9c11"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("73c3b223-e3da-41fd-9fdd-c1ee936bd11c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("83656ebf-cb23-40f1-b799-07f5c5ff2cd6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("8454b86c-350e-4a64-80d2-1d29046edd74"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("b65ce917-48dc-4c0f-99c8-2173325e4875"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: new Guid("c7f110d9-6100-4746-8e43-0cf6a0a585cd"));
        }
    }
}
