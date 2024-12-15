using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InhumanShopApp.Data.Migrations
{
    public partial class AddProductSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Product image url",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Product image url");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "afd03306-b274-4b86-b760-ac4ef53b870f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "22cc8a09-d5c6-4d90-9980-4269463dd7f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "3cc73d94-2b53-482d-9e14-07497fc3be3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f3cb324-2cf8-4a5c-9c9d-57e904d50b67", "AQAAAAEAACcQAAAAEGDVd6gRKHtIbxnDl4GhIkyHkODYF0uztg6FU6rM91k+YfOWUwVkahibIf0Mgaa0SA==", "bc5e1c86-3ec4-4910-bb6b-b68d0104749f" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Count", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, 5, "Durable chew toy for dogs.", "/images/chew_toy.jpg", "Chew Toy", 23.43m },
                    { 2, 2, 5, "Colorful ball with bell for cats.", "/images/cat_ball.jpg", "Cat Ball", 15.99m },
                    { 3, 2, 5, "Swing toy for small birds.", "/images/bird_swing.jpg", "Bird Swing", 12.49m },
                    { 6, 1, 5, "Warm sweater for small dogs.", "/images/dog_sweater.jpg", "Dog Sweater", 27.99m },
                    { 7, 1, 5, "Waterproof raincoat for pets.", "/images/dog_raincoat.jpg", "Raincoat for Dogs", 34.50m },
                    { 11, 3, 5, "Effective flea treatment for pets.", "/images/flea_treatment.jpg", "Flea Treatment", 45.99m },
                    { 12, 3, 5, "Tablets for deworming cats and dogs.", "/images/deworming_tablets.jpg", "Deworming Tablets", 28.75m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Product image url",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Product image url");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9d77f414-6c73-4d40-b5ec-e16ee511aa4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f0bf86cc-1d0b-4d9e-879e-8d1036578a47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "935ce0df-6f42-456a-ae39-3ad04f36d761");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a0f15ba-b0d7-4598-8ba2-2be578d1e42b", "AQAAAAEAACcQAAAAEA62dwqIbK8Z8AIOvrItjVWT7UFzklYfDatjCJ/wwsOCnYOBgNk99t7O8U3lQeTvYA==", "7401a4c4-6278-497c-89bd-78fb409c182c" });
        }
    }
}
