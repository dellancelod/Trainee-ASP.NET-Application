using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TraineeApplication.Migrations
{
    public partial class Newsnotifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsNotifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SenderID = table.Column<string>(nullable: true),
                    ReceiverID = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Approved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsNotifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                column: "ConcurrencyStamp",
                value: "34cd0af1-35b9-4b32-98ba-a222da0dd7a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b440539f-242a-45ec-bd2a-ea163e4d91b3", "AQAAAAEAACcQAAAAEMn7NO0IP90SrhAoY7zuVZ3wRzphpmB8NnN8RioK5exxMwuvzGbIxZ9OdOmpx4JauQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f1c1164-3813-47b5-91f4-adac910e215b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01e8933b-08fc-402e-8ce9-4c7c754bcd73", "AQAAAAEAACcQAAAAEA/Xy6CvQmSvzyGJrPjHUBax67lLj5AzWliRUVCogFRmTS6Iww73MBkImBeSWlOfrQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 13, 23, 1, 948, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 13, 23, 1, 948, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 13, 23, 1, 947, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 13, 23, 1, 948, DateTimeKind.Utc).AddTicks(1101));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsNotifications");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                column: "ConcurrencyStamp",
                value: "cb76e0d0-33e3-47bb-afbe-f6f3f9c1a450");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b357653-58e5-415e-896f-1e22ad8d3ae5", "AQAAAAEAACcQAAAAEGGAGk2+Zpz8juvvGW9LnA4n4fUVPm8pS7/xeCBmi5NXg7+F30waRztsGwUuk833iw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f1c1164-3813-47b5-91f4-adac910e215b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "80755dac-1d69-4d3a-97f6-a438404418f3", "AQAAAAEAACcQAAAAEIAy6/k/SsyRqyuZ5YqXvvLKCkAuciQhGf+o4wFYCxtuasjHfBC19X+RdUevhgPZSA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 25, 22, 726, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 25, 22, 726, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 25, 22, 726, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 18, 12, 25, 22, 726, DateTimeKind.Utc).AddTicks(4724));
        }
    }
}
