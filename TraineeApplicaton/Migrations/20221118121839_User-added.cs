using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TraineeApplication.Migrations
{
    public partial class Useradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                column: "ConcurrencyStamp",
                value: "16e6badd-80c4-4cda-8252-85083a0440d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c9c79e6-8ebd-495c-86a2-ee5e70dc2194", "AQAAAAEAACcQAAAAEKPi8e1Lk9slscKBNXUsrDE3eqs5tF3yi0JHVS1SvS4T5fY5mL6ktDwhflKncWuv7A==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6f1c1164-3813-47b5-91f4-adac910e215b", 0, "5f9926e2-fab0-4bae-af28-9d80e3832c72", "user@email.com", true, false, null, "USER@EMAIL.COM", "USER", "AQAAAAEAACcQAAAAEBBykcsLGP9YmZgDouQ/dIk/gkJoCAVXwtJzVQCXTN60t6/9SjekGh9q2xBFR8F48g==", null, false, "", false, "user" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 18, 37, 845, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 18, 37, 845, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 18, 37, 845, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 18, 37, 845, DateTimeKind.Utc).AddTicks(6387));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f1c1164-3813-47b5-91f4-adac910e215b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                column: "ConcurrencyStamp",
                value: "6fc879a1-3e4d-46a7-abf7-dd0bb0d4db11");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ebb4fdd-472b-4c18-8975-b487fcfd30ea", "AQAAAAEAACcQAAAAEFzv1EourOjgLv+ZAj7XMahVppazWtDNk5XWFUejMSqj17g0z2QhT+tSBm6CmuNqnA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 9, 38, 32, 659, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 9, 38, 32, 659, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 9, 38, 32, 657, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 9, 38, 32, 659, DateTimeKind.Utc).AddTicks(1409));
        }
    }
}
