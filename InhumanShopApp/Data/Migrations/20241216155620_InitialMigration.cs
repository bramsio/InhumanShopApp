using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InhumanShopApp.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    YearsOfExperience = table.Column<int>(type: "int", nullable: true),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Size Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Status identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Chat Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MessageContent = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsFromUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Product Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Product Name"),
                    Count = table.Column<int>(type: "int", nullable: false, comment: "Product count"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product Price"),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Product quanity"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false, comment: "Product description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Product image url")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Order identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Total price of order"),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Order item identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "6f11f079-c87c-4a81-8a9f-d1e4736c42f4", "User", "USER" },
                    { "2", "5f6702b6-73df-4c48-825f-f165ed593937", "Veterinarian", "VETERINARIAN" },
                    { "3", "642a22cd-6342-4887-9f14-23e7839b5c13", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7699db7d-964f-4782-8209-d76562e0fece", 0, "c64987f3-7852-45a9-bfbe-ae054b33f164", "User", "admin@zooshop.com", true, false, null, "Belgin", "ADMIN@ZOOSHOP.COM", "ADMIN@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEPSjdE3ESS3Vp5Np7dSalQnAneY7BLoV6XDRw3j3eY/gj58Nxq4GNbTQRK9bOyXElA==", null, false, "adbc5886-0185-48ff-822c-f7e1809d44c7", false, "admin@zooshop.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TelNumber", "TwoFactorEnabled", "UserName", "YearsOfExperience" },
                values: new object[,]
                {
                    { "a1b2c3d4-1234-5678-9876-abcdefabcdef", 0, "cfd07ba8-7982-45d8-b919-ad4b4c373b44", "Veterinarian", "sarah@zooshop.com", false, false, null, "Dr. Sarah Johnson", null, null, "AQAAAAEAACcQAAAAEFBu1r5ttUMJCW3x2IsT9fXUEDhiRivEZj1Wg7G1HcLb6CxcsYHGdOr0jt56WPUVwA==", null, false, "f4c054e3-c2bf-45a0-8ebc-0507ad76d549", "Small Animals", "+359888123456", false, null, 8 },
                    { "a1b2c3d4-2345-6789-9876-abcdefabcdef", 0, "7c061e07-e54f-4a67-aeef-3464969f5edc", "Veterinarian", "michael@zooshop.com", false, false, null, "Dr. Michael Brown", null, null, "AQAAAAEAACcQAAAAELE1ZPNmBqFE7nzZWxgiEmewbhTqrdc2Bx9DiEYTAlrWkSeRHQAEiIBevpGNC7tFAg==", null, false, "705b0bf9-051c-43c3-88cc-a878b3b7c6f0", "Exotic Animals", "+359888654321", false, null, 12 },
                    { "a1b2c3d4-3456-7890-9876-abcdefabcdef", 0, "166d39c3-82ba-4057-a353-d933138706e0", "Veterinarian", "emma@zooshop.com", false, false, null, "Dr. Emma Davis", null, null, "AQAAAAEAACcQAAAAEBOs/tmSxn+y8IloY/y1dq3Az5kNYKIzVAqTVHaXtNgOW7lvCQjlufExSqxoTvNUdQ==", null, false, "27cbb609-2de0-4405-8f6f-fa374b5cf1c7", "Large Animals", "+359888987654", false, null, 10 },
                    { "a1b2c3d4-4567-8901-9876-abcdefabcdef", 0, "b0dd164a-ff40-417a-b967-60db64c695bb", "Veterinarian", "john@zooshop.com", false, false, null, "Dr. John Smith", null, null, "AQAAAAEAACcQAAAAENy32nghSsFmPMZWowIzxGnvRRohUdOAw86S+e2RrigKUoCbsDHknGbb+FxSIeV4kA==", null, false, "10d1db54-5d4e-48c3-b7d0-a92b7d771551", "Birds", "+359888456789", false, null, 6 },
                    { "a1b2c3d4-5678-9012-9876-abcdefabcdef", 0, "adc4fad7-dd4a-4872-952a-864e1d5e9299", "Veterinarian", "olivia@zooshop.com", false, false, null, "Dr. Olivia Wilson", null, null, "AQAAAAEAACcQAAAAENy2+4LbSpespP5oH6gdI1unuCRdCmYXIfyPpgeSONmkPtrpJEjgQlLHu/87vd7mkg==", null, false, "02696368-0f23-4c26-971b-96d006166e62", "Reptiles", "+359888123789", false, null, 7 },
                    { "a1b2c3d4-6789-0123-9876-abcdefabcdef", 0, "33ef44dc-65ae-4c37-8e8c-61876fe6b6d5", "Veterinarian", "william@zooshop.com", false, false, null, "Dr. William Garcia", null, null, "AQAAAAEAACcQAAAAEEDexIyPn7WgQCE8qUi+vCBBex3ZrSphMmmOnBF0//VV1tECKAxX5xdPUJ5PIs5/Tw==", null, false, "9ed6d645-b679-466e-a06f-81a1edd81271", "Fish", "+359888654987", false, null, 5 },
                    { "a1b2c3d4-7890-1234-9876-abcdefabcdef", 0, "569dc501-b972-4910-907f-c9d2a3bf0047", "Veterinarian", "sophia@zooshop.com", false, false, null, "Dr. Sophia Martinez", null, null, "AQAAAAEAACcQAAAAEM+Uw3GUq2qAXvM90r0bljUyu87u5LNEVmaIxZOCNL3udTO/vfd4mQWnis+ACX74dg==", null, false, "054e614e-36a9-4f21-b033-ea5cf1156079", "Wildlife", "+359888987123", false, null, 15 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Clothes" },
                    { 2, "Toys" },
                    { 3, "Medications" },
                    { 4, "Accessories" },
                    { 5, "Food" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3", "7699db7d-964f-4782-8209-d76562e0fece" },
                    { "2", "a1b2c3d4-1234-5678-9876-abcdefabcdef" },
                    { "2", "a1b2c3d4-2345-6789-9876-abcdefabcdef" },
                    { "2", "a1b2c3d4-3456-7890-9876-abcdefabcdef" },
                    { "2", "a1b2c3d4-4567-8901-9876-abcdefabcdef" },
                    { "2", "a1b2c3d4-5678-9012-9876-abcdefabcdef" },
                    { "2", "a1b2c3d4-6789-0123-9876-abcdefabcdef" },
                    { "2", "a1b2c3d4-7890-1234-9876-abcdefabcdef" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Count", "Description", "ImageUrl", "Name", "Price", "Quantity", "SizeId" },
                values: new object[,]
                {
                    { 1, 5, 50, "High-quality dog food for adult dogs.", "images/Products/Premium_Dog_Food.jpg", "Premium Dog Food", 45.99m, 1, 3 },
                    { 2, 2, 20, "Durable scratching post for cats.", "images/Products/Cat_Scratching_Post.jpg", "Cat Scratching Post", 29.99m, 1, 4 },
                    { 3, 2, 100, "Rubber chew toy to keep your dog entertained.", "images/Products/Dog_Chew_Toy.jpg", "Dog Chew Toy", 15.49m, 1, 2 },
                    { 4, 4, 75, "Adjustable cat collar with a small bell.", "images/Products/Cat_Collar_with_Bell.jpg", "Cat Collar with Bell", 9.99m, 1, 2 },
                    { 5, 4, 30, "Comfortable bed for medium-sized dogs.", "images/Products/Dog_And_Cat_Bed.jpg", "Dog And Cat Bed", 59.99m, 1, 3 },
                    { 6, 5, 40, "Cat litter with odor-neutralizing technology.", "images/Products/Cat_Litter-Odor_Control.jpg", "Cat Litter - Odor Control", 19.99m, 1, 5 },
                    { 7, 3, 60, "Gentle shampoo for dogs with sensitive skin.", "images/Products/Dog_Shampoo-Sensitive_Skin.jpg", "Dog Shampoo - Sensitive Skin", 12.49m, 1, 1 },
                    { 8, 5, 200, "Delicious salmon-flavored treats for cats.", "images/Products/Cat_Treats-Salmon_Flavor.jpg", "Cat Treats - Salmon Flavor", 5.99m, 1, 2 },
                    { 9, 4, 25, "Adjustable harness for comfortable walks.", "images/Products/Dog_Harness-Adjustable.jpg", "Dog Harness - Adjustable", 24.99m, 1, 3 },
                    { 10, 2, 15, "Interactive tunnel toy for cats to play and hide.", "images/Products/Cat_Tunnel.jpg", "Cat Tunnel", 34.99m, 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
