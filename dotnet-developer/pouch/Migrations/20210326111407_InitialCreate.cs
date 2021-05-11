using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(23,8)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "IsDelete", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 8, 18, 14, 7, 15, DateTimeKind.Local).AddTicks(3530), false, new DateTime(2021, 4, 11, 18, 14, 7, 15, DateTimeKind.Local).AddTicks(3530), "ถูกหวย" },
                    { 2, new DateTime(2021, 4, 6, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(810), false, new DateTime(2021, 4, 7, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(810), "เงินเดือน" },
                    { 3, new DateTime(2021, 3, 30, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), false, new DateTime(2021, 3, 31, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), "แม่ให้" },
                    { 4, new DateTime(2021, 3, 28, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), false, new DateTime(2021, 3, 29, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), "ปล้นพี่เสก" },
                    { 5, new DateTime(2021, 3, 30, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), false, new DateTime(2021, 4, 1, 18, 14, 7, 24, DateTimeKind.Local).AddTicks(890), "อาหาร" }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "IsDelete", "ModifiedOn", "Name", "Note", "Status", "TransactionDate", "Type", "Value" },
                values: new object[,]
                {
                    { 2L, 1, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 15064m },
                    { 63L, 3, new DateTime(2018, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 13632m },
                    { 62L, 3, new DateTime(2018, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 55910m },
                    { 60L, 3, new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 72653m },
                    { 58L, 3, new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 61832m },
                    { 57L, 3, new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 75514m },
                    { 52L, 3, new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 34338m },
                    { 50L, 3, new DateTime(2018, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 64889m },
                    { 47L, 3, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 34374m },
                    { 43L, 3, new DateTime(2018, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 75312m },
                    { 42L, 3, new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9838m },
                    { 38L, 3, new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 43701m },
                    { 27L, 3, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18640m },
                    { 23L, 3, new DateTime(2018, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 42860m },
                    { 22L, 3, new DateTime(2018, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18385m },
                    { 20L, 3, new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 63302m },
                    { 19L, 3, new DateTime(2018, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 31680m },
                    { 18L, 3, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 43199m },
                    { 17L, 3, new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 13597m },
                    { 15L, 3, new DateTime(2018, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 64612m },
                    { 14L, 3, new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10372m },
                    { 12L, 3, new DateTime(2018, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 71937m },
                    { 66L, 3, new DateTime(2018, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 33489m },
                    { 9L, 3, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 72373m },
                    { 68L, 3, new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 33560m },
                    { 74L, 3, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 42066m },
                    { 91L, 4, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 50962m },
                    { 82L, 4, new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 31420m },
                    { 69L, 4, new DateTime(2018, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 73091m },
                    { 67L, 4, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4146m },
                    { 56L, 4, new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 71351m },
                    { 53L, 4, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 64986m },
                    { 48L, 4, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 68578m },
                    { 45L, 4, new DateTime(2018, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 44833m },
                    { 44L, 4, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 64461m },
                    { 36L, 4, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 66292m },
                    { 31L, 4, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1430m },
                    { 30L, 4, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 73138m },
                    { 24L, 4, new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 61080m },
                    { 97L, 3, new DateTime(2018, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18679m },
                    { 96L, 3, new DateTime(2018, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 22548m },
                    { 94L, 3, new DateTime(2018, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 33066m }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "IsDelete", "ModifiedOn", "Name", "Note", "Status", "TransactionDate", "Type", "Value" },
                values: new object[,]
                {
                    { 87L, 3, new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 67065m },
                    { 84L, 3, new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 35131m },
                    { 81L, 3, new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 75167m },
                    { 78L, 3, new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 46268m },
                    { 75L, 3, new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 46115m },
                    { 71L, 3, new DateTime(2018, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 23931m },
                    { 95L, 2, new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 43235m },
                    { 93L, 2, new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 7599m },
                    { 88L, 2, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 7137m },
                    { 85L, 1, new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 67609m },
                    { 80L, 1, new DateTime(2018, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 68928m },
                    { 73L, 1, new DateTime(2018, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 48945m },
                    { 72L, 1, new DateTime(2018, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 23133m },
                    { 70L, 1, new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 32916m },
                    { 64L, 1, new DateTime(2018, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3580m },
                    { 61L, 1, new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 71729m },
                    { 55L, 1, new DateTime(2018, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 62687m },
                    { 54L, 1, new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 29308m },
                    { 41L, 1, new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 36444m },
                    { 40L, 1, new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 33148m },
                    { 35L, 1, new DateTime(2018, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 11211m },
                    { 33L, 1, new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 17271m },
                    { 26L, 1, new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 38460m },
                    { 25L, 1, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 46883m },
                    { 21L, 1, new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8443m },
                    { 13L, 1, new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8440m },
                    { 10L, 1, new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 61226m },
                    { 7L, 1, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 56667m },
                    { 5L, 1, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 55039m },
                    { 4L, 1, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 46894m },
                    { 89L, 1, new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 42079m },
                    { 90L, 1, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 44945m },
                    { 99L, 1, new DateTime(2018, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 25796m },
                    { 100L, 1, new DateTime(2018, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3760m },
                    { 86L, 2, new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 42553m },
                    { 83L, 2, new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10337m },
                    { 79L, 2, new DateTime(2018, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 26470m },
                    { 77L, 2, new DateTime(2018, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 41898m },
                    { 76L, 2, new DateTime(2018, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 69823m },
                    { 65L, 2, new DateTime(2018, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 76816m },
                    { 59L, 2, new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 27059m },
                    { 51L, 2, new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 699m }
                });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "IsDelete", "ModifiedOn", "Name", "Note", "Status", "TransactionDate", "Type", "Value" },
                values: new object[,]
                {
                    { 49L, 2, new DateTime(2018, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2675m },
                    { 46L, 2, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 57362m },
                    { 92L, 4, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "ปันผล", null, 0, new DateTime(2018, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 14280m },
                    { 39L, 2, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 52519m },
                    { 34L, 2, new DateTime(2018, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 65535m },
                    { 32L, 2, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 74582m },
                    { 29L, 2, new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 13157m },
                    { 28L, 2, new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "เก็บเงินได้", null, 0, new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 68340m },
                    { 16L, 2, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "ถูกหวย", null, 0, new DateTime(2018, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5339m },
                    { 11L, 2, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 38462m },
                    { 8L, 2, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 46563m },
                    { 6L, 2, new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "เงินเดือน", null, 0, new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 75686m },
                    { 3L, 2, new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 36987m },
                    { 1L, 2, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2019, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินข้าว", null, 0, new DateTime(2018, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 52011m },
                    { 37L, 2, new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "กินเหล้า", null, 0, new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 21739m },
                    { 98L, 4, new DateTime(2018, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2018, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ซื้อหวย", null, 0, new DateTime(2018, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10451m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CategoryId",
                table: "Transactions",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
