using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class changeFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Transactions",
                newName: "FinancialType");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 14, 18, 29, 53, 73, DateTimeKind.Local).AddTicks(1310), new DateTime(2021, 4, 16, 18, 29, 53, 73, DateTimeKind.Local).AddTicks(1310) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 13, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6710), new DateTime(2021, 4, 16, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 13, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6790), new DateTime(2021, 4, 15, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 3, 31, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6800), new DateTime(2021, 4, 4, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 5, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6800), new DateTime(2021, 4, 7, 18, 29, 53, 82, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 61849m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 67203m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 64552m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, 3, new DateTime(2019, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 5071m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 25511m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 42487m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, 3, new DateTime(2019, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 71394m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 67062m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 72281m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 55761m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 3, new DateTime(2019, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 62338m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 8440m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 64370m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, 1, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 44551m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, 3, new DateTime(2019, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 65981m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 3, new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 37227m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 3, new DateTime(2019, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 44432m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 2935m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 47197m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 20655m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, 1, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 28141m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, 3, new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 50237m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 29404m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, 1, new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 9661m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 75857m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, 1, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 73966m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 75380m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, 3, new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 29459m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 53440m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 16269m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 3, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 78591m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, 1, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 19545m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 72878m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 27658m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 76025m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 33257m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 50301m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 78672m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2018, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 65753m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 50966m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 28671m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 3, new DateTime(2018, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 27173m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 78248m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2019, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 17393m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 54582m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 7374m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 57212m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 7649m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 15078m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 10340m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 21833m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 47143m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 69316m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, 3, new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 11448m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, 3, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 69796m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 19783m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 3, new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 49168m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, 3, new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 64205m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 34209m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 47880m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, 3, new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 73694m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 1169m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 49327m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 13512m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 26667m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 55452m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, 3, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 18215m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 40771m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, 1, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 70713m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, 3, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 20459m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 5371m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2018, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 21080m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 47153m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 56799m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 45151m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2019, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 64589m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 1, new DateTime(2018, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 820m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 72788m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, 1, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 853m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", 25833m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 1941m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 13200m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 37461m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", 70678m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 33243m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, 3, new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 39381m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 49736m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 42004m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, 1, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 64574m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 27620m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2018, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 2112m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", 15055m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 60167m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2018, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 39631m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 1657m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CategoryId", "ModifiedOn", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", 43274m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", 71780m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ModifiedOn", "Note", "Value" },
                values: new object[] { new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", 36956m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 4, 3, new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 78095m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CategoryId", "FinancialType", "ModifiedOn", "Note", "Value" },
                values: new object[] { 3, 3, new DateTime(2018, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", 77350m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FinancialType",
                table: "Transactions",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Transactions",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 8, 18, 14, 7, 15, DateTimeKind.Local).AddTicks(3530), new DateTime(2021, 4, 11, 18, 14, 7, 15, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 4, 6, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(810), new DateTime(2021, 4, 7, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 3, 30, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), new DateTime(2021, 3, 31, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 3, 28, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), new DateTime(2021, 3, 29, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2021, 3, 30, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), new DateTime(2021, 4, 1, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 52011m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 15064m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 36987m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 1, 46894m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 55039m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 75686m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 56667m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 46563m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 72373m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 61226m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 1, 38462m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 71937m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 8440m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 3, 10372m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 64612m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2019, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 5339m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 13597m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 43199m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 31680m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 63302m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 8443m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 18385m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 42860m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 3, 61080m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 46883m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 38460m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 18640m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 1, 68340m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 3, 13157m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 73138m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 1, 1430m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 74582m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 17271m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 3, 65535m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 1, 11211m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 3, 66292m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 21739m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 43701m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 52519m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 33148m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 36444m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 1, 9838m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 3, 75312m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 64461m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 44833m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 57362m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2019, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 34374m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 68578m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 2675m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 64889m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2018, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 3, 699m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 34338m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 64986m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 1, 29308m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 62687m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 4, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 71351m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 1, 75514m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 61832m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 27059m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 72653m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 1, 71729m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 3, 55910m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 13632m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 3580m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 3, 76816m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 33489m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 1, 4146m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 33560m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 4, new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 73091m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 1, 32916m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 3, 23931m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 23133m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 48945m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 42066m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 46115m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 69823m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 41898m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 3, 46268m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 26470m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 68928m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 75167m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 31420m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 10337m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 3, 35131m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 67609m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 2, new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 1, 42553m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 67065m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 7137m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 3, 42079m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 44945m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 50962m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 4, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 14280m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 7599m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 33066m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 2, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 43235m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { 3, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 22548m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 18679m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "ModifiedOn", "Name", "Note", "Value" },
                values: new object[] { new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 10451m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 1, 25796m });

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CategoryId", "ModifiedOn", "Name", "Note", "Type", "Value" },
                values: new object[] { 1, new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 1, 3760m });
        }
    }
}
