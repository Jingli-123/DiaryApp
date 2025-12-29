using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "This is your first diary entry. Feel free to edit or delete it.", new DateTime(2025, 12, 29, 22, 16, 15, 744, DateTimeKind.Local).AddTicks(4706), "Welcome to Your Diary" },
                    { 2, "Start writing your thoughts and experiences here. Your diary is a safe space.", new DateTime(2025, 12, 29, 22, 16, 15, 744, DateTimeKind.Local).AddTicks(4709), "Getting Started" },
                    { 3, "Try to write regularly, be honest with yourself, and don't worry about grammar or spelling.", new DateTime(2025, 12, 29, 22, 16, 15, 744, DateTimeKind.Local).AddTicks(4712), "Tips for Writing" },
                    { 4, "Take a moment each day to reflect on what happened, how you felt, and what you learned.", new DateTime(2025, 12, 29, 22, 16, 15, 744, DateTimeKind.Local).AddTicks(4714), "Reflecting on Your Day" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
