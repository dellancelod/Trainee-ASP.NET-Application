using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TraineeApplication.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                column: "ConcurrencyStamp",
                value: "91ef47c3-77fb-4f3d-b5fe-42fc62f35e76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6783fcca-36c0-42f7-a8ec-5893ac0f22dd", "AQAAAAEAACcQAAAAEPkr3KAD843uISwRODg1hzHxuNExJqp/vXAtjPxRa7oTyb1mMRb4muaU84XsBpQHLA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 16, 38, 19, 292, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 16, 38, 19, 292, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 16, 38, 19, 292, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "MetaDescription", "MetaKeywords", "MetaTitle", "Subtitle", "Text", "Title", "TitleImagePath" },
                values: new object[] { new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"), "PageNews", new DateTime(2022, 11, 15, 16, 38, 19, 291, DateTimeKind.Utc).AddTicks(6490), null, null, null, null, "Вміст заповнюється адміністратором", "Новини", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                column: "ConcurrencyStamp",
                value: "be08ff0b-751c-4f94-ab44-7f1a2eb238e5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b6f40da-7f45-477c-aafc-38eb0c8d7a34", "AQAAAAEAACcQAAAAEFK8aLFcknmcjn8Kq1vtlH9V5+SmPvpTFFKy19mj4lN0HVrvo8O/vAingoV1IV49sA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 14, 47, 15, 355, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 14, 47, 15, 355, DateTimeKind.Utc).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 14, 47, 15, 355, DateTimeKind.Utc).AddTicks(3976));
        }
    }
}
