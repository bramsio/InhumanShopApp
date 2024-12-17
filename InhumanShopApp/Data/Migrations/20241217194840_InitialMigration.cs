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
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "ProductSize",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "int", nullable: false),
                    SizesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => new { x.ProductsId, x.SizesId });
                    table.ForeignKey(
                        name: "FK_ProductSize_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_Sizes_SizesId",
                        column: x => x.SizesId,
                        principalTable: "Sizes",
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
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Product quanity"),
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CardHolderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "c3260e38-4360-402c-bcbf-8b2040ae1e58", "User", "USER" },
                    { "2", "6dbd8bf0-8829-4bd7-83dc-65165c77f6af", "Veterinarian", "VETERINARIAN" },
                    { "3", "767203e2-5bd5-47e4-ab56-d24d55aa5473", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "7699db7d-964f-4782-8209-d76562e0fece", 0, "957b6e79-cf85-4fdd-ac29-b229491755eb", "admin@zooshop.com", true, false, null, "Belgin", "ADMIN@ZOOSHOP.COM", "ADMIN@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEMyfNKIRf7IhSSBHz4cmh23X4AWA4jFWwRQ+AqrVynSn5W2rEg73RBf7RuD+JgvHIw==", null, false, "cec13a9e-b68a-481a-80af-371522e8cf41", false, "admin@zooshop.com", "User" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Specialization", "TelNumber", "TwoFactorEnabled", "UserName", "UserType", "YearsOfExperience" },
                values: new object[,]
                {
                    { "a1b2c3d4-1234-5678-9876-abcdefabcdef", 0, "da5149b2-b394-47f1-823b-97c72889f326", "sarah@zooshop.com", false, false, null, "Dr. Sarah Johnson", "SARAH@ZOOSHOP.COM", "SARAH@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEAue0Yfu+7zbXmsbHDRlKVkoe/6jENCjUOyD3Fba/KxgtLSwiokTM+2d7TmdCGOblA==", null, false, "4c4b9e36-b46f-42bb-ad1c-6a09c86d4792", "Small Animals", "+359888123456", false, "sarah@zooshop.com", "Veterinarian", 8 },
                    { "a1b2c3d4-2345-6789-9876-abcdefabcdef", 0, "e001cd27-976b-40e1-b74d-df896ad514e3", "michael@zooshop.com", false, false, null, "Dr. Michael Brown", "MICHAEL@ZOOSHOP.COM", "MICHAEL@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEPFkxvMWOkElUHWM5ReSiTAdyUfQBuES98HvZueR3vhl0NSvIOnEvXxUxytTNiaJrQ==", null, false, "ff24dadc-4ed8-4d31-b9ca-05917311e081", "Exotic Animals", "+359888654321", false, "michael@zooshop.com", "Veterinarian", 12 },
                    { "a1b2c3d4-3456-7890-9876-abcdefabcdef", 0, "9f1ce7dd-19fa-4ced-9138-0973fe5180fe", "emma@zooshop.com", false, false, null, "Dr. Emma Davis", "EMMA@ZOOSHOP.COM", "EMMA@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEEru0Vs5qDW1/9Jy84IujVUEixyqJXd1P02HkZQwunp/7cP1/iM8mEw9XzhMAtPNKQ==", null, false, "f0c111ec-fdc7-40ce-8377-b0a9d11cf86a", "Large Animals", "+359888987654", false, "emma@zooshop.com", "Veterinarian", 10 },
                    { "a1b2c3d4-4567-8901-9876-abcdefabcdef", 0, "9dcbc29d-c9bc-4120-bc59-4b9d2ed5e7af", "john@zooshop.com", false, false, null, "Dr. John Smith", "JOHN@ZOOSHOP.COM", "JOHN@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEIV54PFjtfMq6ruLELOioyc8htclvHJyGviYc3wNPaev/zHtQ8YDsNvP3FkMVqNHMA==", null, false, "7be556e1-e03b-4d42-90d5-37b8b93f9688", "Birds", "+359888456789", false, "john@zooshop.com", "Veterinarian", 6 },
                    { "a1b2c3d4-5678-9012-9876-abcdefabcdef", 0, "7a823afa-8d8c-458c-938c-597d83e9115d", "olivia@zooshop.com", false, false, null, "Dr. Olivia Wilson", "OLIVIA@ZOOSHOP.COM", "OLIVIA@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEFxhl1X+BzzhfXN91OlIo9PPSMdY4KdTOoL88XdFWOHuJtui2Gc9c1pNw6taaYNJww==", null, false, "ca2bca7e-dceb-4ed8-ac5e-c26d12c1c9fa", "Reptiles", "+359888123789", false, "olivia@zooshop.com", "Veterinarian", 7 },
                    { "a1b2c3d4-6789-0123-9876-abcdefabcdef", 0, "3f094e77-5b6a-4a2f-98e6-278ebe0a8075", "william@zooshop.com", false, false, null, "Dr. William Garcia", "WILLIAM@ZOOSHOP.COM", "WILLIAM@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEIW3qcq2P3XI1ZAja/Kj2JKmBbTYdB+4QckpFz4y2XzZ0Q2VTKoSiFVYzTcG0zJQbg==", null, false, "775a56df-5918-4286-9600-78e1d9102563", "Fish", "+359888654987", false, "william@zooshop.com", "Veterinarian", 5 },
                    { "a1b2c3d4-7890-1234-9876-abcdefabcdef", 0, "8987a47e-045c-49bf-bc43-b7e1e8fabf62", "sophia@zooshop.com", false, false, null, "Dr. Sophia Martinez", "SOPHIA@ZOOSHOP.COM", "SOPHIA@ZOOSHOP.COM", "AQAAAAEAACcQAAAAEFxMNCLnhSG8aPLd+2ikph3061KyHNCT2HMXr90RogXCAtSYgZDUbg6NKxhSmZm2aA==", null, false, "beca75aa-c34c-43ad-b375-4d91446caacb", "Wildlife", "+359888987123", false, "sophia@zooshop.com", "Veterinarian", 15 }
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
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Active" },
                    { 2, "Completed" },
                    { 3, "Cancelled" }
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
                columns: new[] { "Id", "CategoryId", "Count", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 5, 50, "High-quality dog food for adult dogs.", "images/Products/Premium_Dog_Food.jpg", "Premium Dog Food", 45.99m },
                    { 2, 2, 20, "Durable scratching post for cats.", "images/Products/Cat_Scratching_Post.jpg", "Cat Scratching Post", 29.99m },
                    { 3, 2, 100, "Rubber chew toy to keep your dog entertained.", "images/Products/Dog_Chew_Toy.jpg", "Dog Chew Toy", 15.49m },
                    { 4, 4, 75, "Adjustable cat collar with a small bell.", "images/Products/Cat_Collar_with_Bell.jpg", "Cat Collar with Bell", 9.99m },
                    { 5, 4, 30, "Comfortable bed for medium-sized dogs.", "images/Products/Dog_And_Cat_Bed.jpg", "Dog And Cat Bed", 59.99m },
                    { 6, 5, 40, "Cat litter with odor-neutralizing technology.", "images/Products/Cat_Litter-Odor_Control.jpg", "Cat Litter - Odor Control", 19.99m },
                    { 7, 3, 60, "Gentle shampoo for dogs with sensitive skin.", "images/Products/Dog_Shampoo-Sensitive_Skin.jpg", "Dog Shampoo - Sensitive Skin", 12.49m },
                    { 8, 5, 200, "Delicious salmon-flavored treats for cats.", "images/Products/Cat_Treats-Salmon_Flavor.jpg", "Cat Treats - Salmon Flavor", 5.99m },
                    { 9, 4, 25, "Adjustable harness for comfortable walks.", "images/Products/Dog_Harness-Adjustable.jpg", "Dog Harness - Adjustable", 24.99m },
                    { 10, 2, 15, "Interactive tunnel toy for cats to play and hide.", "images/Products/Cat_Tunnel.jpg", "Cat Tunnel", 34.99m }
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
                name: "IX_OrderItems_SizeId",
                table: "OrderItems",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_SizesId",
                table: "ProductSize",
                column: "SizesId");
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
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
