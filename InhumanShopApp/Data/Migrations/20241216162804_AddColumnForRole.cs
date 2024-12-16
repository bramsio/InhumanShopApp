using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InhumanShopApp.Data.Migrations
{
    public partial class AddColumnForRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "AspNetUsers",
                newName: "UserType");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6f7d54b8-5ff6-43da-b609-cb5e960f3e1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "78d0151c-4829-4cd0-b981-5e3da1a48a92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "4eb6a872-4341-4094-9df2-cdc517a6a660");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d366199a-a2f4-486a-9925-962041095b9a", "AQAAAAEAACcQAAAAEGcfnO4qnpkDN30iC19WWiHihAvU/4VUrmyxJbOBfAZtC4RYi2PDVfjFDoAJD820Rw==", "d0ed4383-4fa5-4b4e-9499-f09c8d379bc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-1234-5678-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dac1e871-8ef0-4ce3-8696-f233117d289b", "AQAAAAEAACcQAAAAEJt8z8Geqq1oeyqvCp3Pq1WCvtNtQ/7AvjTCrosonZ/idJZdqyyX83isdqlQlRMYKw==", "0f99a690-423c-4140-a18e-6422d46d3858" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-2345-6789-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25702291-202e-4e7a-b1a6-0deb9a42dd1c", "AQAAAAEAACcQAAAAEPnqLSJ7zre6yFp08G4/3ASXJlIZgNm5sIoC5AU4+MYmD+Z7HoVYnT80wGobLHqgFg==", "644f19ea-55b5-4875-96b6-7bdd385676fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-3456-7890-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0adc55b5-6265-41a3-80e9-5fa9456fd23f", "AQAAAAEAACcQAAAAEPJ1tTvld8akOiFyUyvkdEYk3uki1jLFxjkReRbRSxQuzcgv/wR5Zi2tHTJq8y0vGg==", "12fd690a-afc3-4c13-b71a-c5c0d835fd93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-4567-8901-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21791ed6-3ba2-47aa-9e4c-1e2ae3e25195", "AQAAAAEAACcQAAAAEFq1WKJBATTHbRlyjBTqQOdoAnV6Na6ddm4LAZWCgpwipU1kovP5rBj6kge4k7Y3vg==", "d7573fca-0db6-4093-aef7-5aedeebfd16a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-5678-9012-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "138811a7-7544-47f0-a646-b621e6a97023", "AQAAAAEAACcQAAAAEEByUXTbKEl1PCUnHqBXg+Fx8DiU5qBsVgbFCVLb785qPOhHpMeBJvv8b+gbbYD5tg==", "5a26b892-ccc8-496f-a993-8a3ab6357e1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-6789-0123-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb57004-682d-4f5f-abc8-77b418b8161c", "AQAAAAEAACcQAAAAEN41lXmBF9oQLRFfSQhcEPX+K0hqD1uthD1NEjHC6iWpascfWKyRJgTIsukFLl7+jQ==", "c78ed8ce-e47c-4b71-98f8-e89064217e0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-7890-1234-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85b0c7c2-f9c8-47c4-9d88-13ecdb29e0dc", "AQAAAAEAACcQAAAAEFD8m1tyrV+YrBxUU9fnNsWCCMx1IhWVrvmGmrGbO3H5MmpiVT7rjIu7ZkfOjcJkGw==", "df028a78-46f3-4b96-a192-1fdb3b6d5c01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "AspNetUsers",
                newName: "Discriminator");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6f11f079-c87c-4a81-8a9f-d1e4736c42f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5f6702b6-73df-4c48-825f-f165ed593937");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "642a22cd-6342-4887-9f14-23e7839b5c13");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c64987f3-7852-45a9-bfbe-ae054b33f164", "AQAAAAEAACcQAAAAEPSjdE3ESS3Vp5Np7dSalQnAneY7BLoV6XDRw3j3eY/gj58Nxq4GNbTQRK9bOyXElA==", "adbc5886-0185-48ff-822c-f7e1809d44c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-1234-5678-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfd07ba8-7982-45d8-b919-ad4b4c373b44", "AQAAAAEAACcQAAAAEFBu1r5ttUMJCW3x2IsT9fXUEDhiRivEZj1Wg7G1HcLb6CxcsYHGdOr0jt56WPUVwA==", "f4c054e3-c2bf-45a0-8ebc-0507ad76d549" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-2345-6789-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c061e07-e54f-4a67-aeef-3464969f5edc", "AQAAAAEAACcQAAAAELE1ZPNmBqFE7nzZWxgiEmewbhTqrdc2Bx9DiEYTAlrWkSeRHQAEiIBevpGNC7tFAg==", "705b0bf9-051c-43c3-88cc-a878b3b7c6f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-3456-7890-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "166d39c3-82ba-4057-a353-d933138706e0", "AQAAAAEAACcQAAAAEBOs/tmSxn+y8IloY/y1dq3Az5kNYKIzVAqTVHaXtNgOW7lvCQjlufExSqxoTvNUdQ==", "27cbb609-2de0-4405-8f6f-fa374b5cf1c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-4567-8901-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0dd164a-ff40-417a-b967-60db64c695bb", "AQAAAAEAACcQAAAAENy32nghSsFmPMZWowIzxGnvRRohUdOAw86S+e2RrigKUoCbsDHknGbb+FxSIeV4kA==", "10d1db54-5d4e-48c3-b7d0-a92b7d771551" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-5678-9012-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "adc4fad7-dd4a-4872-952a-864e1d5e9299", "AQAAAAEAACcQAAAAENy2+4LbSpespP5oH6gdI1unuCRdCmYXIfyPpgeSONmkPtrpJEjgQlLHu/87vd7mkg==", "02696368-0f23-4c26-971b-96d006166e62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-6789-0123-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33ef44dc-65ae-4c37-8e8c-61876fe6b6d5", "AQAAAAEAACcQAAAAEEDexIyPn7WgQCE8qUi+vCBBex3ZrSphMmmOnBF0//VV1tECKAxX5xdPUJ5PIs5/Tw==", "9ed6d645-b679-466e-a06f-81a1edd81271" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1b2c3d4-7890-1234-9876-abcdefabcdef",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "569dc501-b972-4910-907f-c9d2a3bf0047", "AQAAAAEAACcQAAAAEM+Uw3GUq2qAXvM90r0bljUyu87u5LNEVmaIxZOCNL3udTO/vfd4mQWnis+ACX74dg==", "054e614e-36a9-4f21-b033-ea5cf1156079" });
        }
    }
}
