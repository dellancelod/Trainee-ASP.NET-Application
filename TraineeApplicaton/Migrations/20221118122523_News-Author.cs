using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TraineeApplication.Migrations
{
    public partial class NewsAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorID",
                table: "NewsItems",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "NewsItems");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f1c1164-3813-47b5-91f4-adac910e215b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f9926e2-fab0-4bae-af28-9d80e3832c72", "AQAAAAEAACcQAAAAEBBykcsLGP9YmZgDouQ/dIk/gkJoCAVXwtJzVQCXTN60t6/9SjekGh9q2xBFR8F48g==" });

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
    }
}
