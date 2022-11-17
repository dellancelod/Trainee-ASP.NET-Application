using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TraineeApplication.Migrations
{
    public partial class MessageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MessageItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    TitleImagePath = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    SenderName = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa165f2-90a8-452b-afda-bd8f3dd382ae",
                column: "ConcurrencyStamp",
                value: "5824ec8f-d1f4-4feb-8439-9aa2b46d5945");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "410fd6fc-c0eb-4671-b6b9-f245d78a8516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "703214f9-cd15-4d63-b855-56e18ce80b6d", "AQAAAAEAACcQAAAAEJsaIKfcZbIn/y3Yrl35CXRcviz4NjdQ5Gtjc+asa8c/XUhTJiw093b2FHsas/bNsg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("673c93b2-866d-4885-bca2-3f66f184dff5"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 10, 26, 48, 762, DateTimeKind.Utc).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("a76456fb-9a51-40c8-812b-00921c81f38c"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 10, 26, 48, 762, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 10, 26, 48, 762, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 17, 10, 26, 48, 762, DateTimeKind.Utc).AddTicks(8201));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MessageItems");

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
                keyValue: new Guid("b488f7aa-9ebf-4ee5-9e4b-fc22f0de4e1d"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 16, 38, 19, 291, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("b6de0903-3ba8-44b2-a5d9-f03d315098be"),
                column: "DateAdded",
                value: new DateTime(2022, 11, 15, 16, 38, 19, 292, DateTimeKind.Utc).AddTicks(208));
        }
    }
}
