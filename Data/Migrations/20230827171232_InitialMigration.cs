using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MakeYourDiet.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Fats = table.Column<int>(type: "INTEGER", nullable: false),
                    Carbons = table.Column<int>(type: "INTEGER", nullable: false),
                    Proteins = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastActive = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Carbons", "Fats", "Name", "Proteins", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 1, "Product 1", 1, 100 },
                    { 2, 2, 2, "Product 2", 2, 100 },
                    { 3, 3, 3, "Product 3", 3, 100 },
                    { 4, 4, 4, "Product 4", 4, 100 },
                    { 5, 5, 5, "Product 5", 5, 100 },
                    { 6, 6, 6, "Product 6", 6, 100 },
                    { 7, 7, 7, "Product 7", 7, 100 },
                    { 8, 8, 8, "Product 8", 8, 100 },
                    { 9, 9, 9, "Product 9", 9, 100 },
                    { 10, 10, 10, "Product 10", 10, 100 },
                    { 11, 11, 11, "Product 11", 11, 100 },
                    { 12, 12, 12, "Product 12", 12, 100 },
                    { 13, 13, 13, "Product 13", 13, 100 },
                    { 14, 14, 14, "Product 14", 14, 100 },
                    { 15, 15, 15, "Product 15", 15, 100 },
                    { 16, 16, 16, "Product 16", 16, 100 },
                    { 17, 17, 17, "Product 17", 17, 100 },
                    { 18, 18, 18, "Product 18", 18, 100 },
                    { 19, 19, 19, "Product 19", 19, 100 },
                    { 20, 20, 20, "Product 20", 20, 100 },
                    { 21, 21, 21, "Product 21", 21, 100 },
                    { 22, 22, 22, "Product 22", 22, 100 },
                    { 23, 23, 23, "Product 23", 23, 100 },
                    { 24, 24, 24, "Product 24", 24, 100 },
                    { 25, 25, 25, "Product 25", 25, 100 },
                    { 26, 26, 26, "Product 26", 26, 100 },
                    { 27, 27, 27, "Product 27", 27, 100 },
                    { 28, 28, 28, "Product 28", 28, 100 },
                    { 29, 29, 29, "Product 29", 29, 100 },
                    { 30, 30, 30, "Product 30", 30, 100 },
                    { 31, 31, 31, "Product 31", 31, 100 },
                    { 32, 32, 32, "Product 32", 32, 100 },
                    { 33, 33, 33, "Product 33", 33, 100 },
                    { 34, 34, 34, "Product 34", 34, 100 },
                    { 35, 35, 35, "Product 35", 35, 100 },
                    { 36, 36, 36, "Product 36", 36, 100 },
                    { 37, 37, 37, "Product 37", 37, 100 },
                    { 38, 38, 38, "Product 38", 38, 100 },
                    { 39, 39, 39, "Product 39", 39, 100 },
                    { 40, 40, 40, "Product 40", 40, 100 },
                    { 41, 41, 41, "Product 41", 41, 100 },
                    { 42, 42, 42, "Product 42", 42, 100 },
                    { 43, 43, 43, "Product 43", 43, 100 },
                    { 44, 44, 44, "Product 44", 44, 100 },
                    { 45, 45, 45, "Product 45", 45, 100 },
                    { 46, 46, 46, "Product 46", 46, 100 },
                    { 47, 47, 47, "Product 47", 47, 100 },
                    { 48, 48, 48, "Product 48", 48, 100 },
                    { 49, 49, 49, "Product 49", 49, 100 },
                    { 50, 50, 50, "Product 50", 50, 100 },
                    { 51, 51, 51, "Product 51", 51, 100 },
                    { 52, 52, 52, "Product 52", 52, 100 },
                    { 53, 53, 53, "Product 53", 53, 100 },
                    { 54, 54, 54, "Product 54", 54, 100 },
                    { 55, 55, 55, "Product 55", 55, 100 },
                    { 56, 56, 56, "Product 56", 56, 100 },
                    { 57, 57, 57, "Product 57", 57, 100 },
                    { 58, 58, 58, "Product 58", 58, 100 },
                    { 59, 59, 59, "Product 59", 59, 100 },
                    { 60, 60, 60, "Product 60", 60, 100 },
                    { 61, 61, 61, "Product 61", 61, 100 },
                    { 62, 62, 62, "Product 62", 62, 100 },
                    { 63, 63, 63, "Product 63", 63, 100 },
                    { 64, 64, 64, "Product 64", 64, 100 },
                    { 65, 65, 65, "Product 65", 65, 100 },
                    { 66, 66, 66, "Product 66", 66, 100 },
                    { 67, 67, 67, "Product 67", 67, 100 },
                    { 68, 68, 68, "Product 68", 68, 100 },
                    { 69, 69, 69, "Product 69", 69, 100 },
                    { 70, 70, 70, "Product 70", 70, 100 },
                    { 71, 71, 71, "Product 71", 71, 100 },
                    { 72, 72, 72, "Product 72", 72, 100 },
                    { 73, 73, 73, "Product 73", 73, 100 },
                    { 74, 74, 74, "Product 74", 74, 100 },
                    { 75, 75, 75, "Product 75", 75, 100 },
                    { 76, 76, 76, "Product 76", 76, 100 },
                    { 77, 77, 77, "Product 77", 77, 100 },
                    { 78, 78, 78, "Product 78", 78, 100 },
                    { 79, 79, 79, "Product 79", 79, 100 },
                    { 80, 80, 80, "Product 80", 80, 100 },
                    { 81, 81, 81, "Product 81", 81, 100 },
                    { 82, 82, 82, "Product 82", 82, 100 },
                    { 83, 83, 83, "Product 83", 83, 100 },
                    { 84, 84, 84, "Product 84", 84, 100 },
                    { 85, 85, 85, "Product 85", 85, 100 },
                    { 86, 86, 86, "Product 86", 86, 100 },
                    { 87, 87, 87, "Product 87", 87, 100 },
                    { 88, 88, 88, "Product 88", 88, 100 },
                    { 89, 89, 89, "Product 89", 89, 100 },
                    { 90, 90, 90, "Product 90", 90, 100 },
                    { 91, 91, 91, "Product 91", 91, 100 },
                    { 92, 92, 92, "Product 92", 92, 100 },
                    { 93, 93, 93, "Product 93", 93, 100 },
                    { 94, 94, 94, "Product 94", 94, 100 },
                    { 95, 95, 95, "Product 95", 95, 100 },
                    { 96, 96, 96, "Product 96", 96, 100 },
                    { 97, 97, 97, "Product 97", 97, 100 },
                    { 98, 98, 98, "Product 98", 98, 100 },
                    { 99, 99, 99, "Product 99", 99, 100 },
                    { 100, 100, 100, "Product 100", 100, 100 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Gender", "LastActive", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1730), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1732), "password", "User 1" },
                    { 2, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1754), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1755), "password", "User 2" },
                    { 3, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1756), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1756), "password", "User 3" },
                    { 4, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1757), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1757), "password", "User 4" },
                    { 5, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1758), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1758), "password", "User 5" },
                    { 6, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1759), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1760), "password", "User 6" },
                    { 7, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1760), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1761), "password", "User 7" },
                    { 8, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1762), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1762), "password", "User 8" },
                    { 9, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1763), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1763), "password", "User 9" },
                    { 10, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1764), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1764), "password", "User 10" },
                    { 11, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1765), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1766), "password", "User 11" },
                    { 12, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1766), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1767), "password", "User 12" },
                    { 13, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1767), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1768), "password", "User 13" },
                    { 14, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1768), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1769), "password", "User 14" },
                    { 15, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1770), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1770), "password", "User 15" },
                    { 16, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1771), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1771), "password", "User 16" },
                    { 17, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1772), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1772), "password", "User 17" },
                    { 18, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1773), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1773), "password", "User 18" },
                    { 19, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1774), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1774), "password", "User 19" },
                    { 20, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1775), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1775), "password", "User 20" },
                    { 21, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1776), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1776), "password", "User 21" },
                    { 22, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1777), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1777), "password", "User 22" },
                    { 23, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1778), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1778), "password", "User 23" },
                    { 24, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1779), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1779), "password", "User 24" },
                    { 25, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1780), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1780), "password", "User 25" },
                    { 26, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1781), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1781), "password", "User 26" },
                    { 27, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1782), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1782), "password", "User 27" },
                    { 28, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1783), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1783), "password", "User 28" },
                    { 29, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1784), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1784), "password", "User 29" },
                    { 30, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1785), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1785), "password", "User 30" },
                    { 31, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1786), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1786), "password", "User 31" },
                    { 32, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1787), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1787), "password", "User 32" },
                    { 33, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1788), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1788), "password", "User 33" },
                    { 34, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1812), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1812), "password", "User 34" },
                    { 35, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1813), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1814), "password", "User 35" },
                    { 36, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1814), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1815), "password", "User 36" },
                    { 37, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1816), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1816), "password", "User 37" },
                    { 38, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1817), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1817), "password", "User 38" },
                    { 39, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1818), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1818), "password", "User 39" },
                    { 40, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1819), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1819), "password", "User 40" },
                    { 41, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1820), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1820), "password", "User 41" },
                    { 42, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1821), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1821), "password", "User 42" },
                    { 43, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1822), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1822), "password", "User 43" },
                    { 44, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1823), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1823), "password", "User 44" },
                    { 45, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1823), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1824), "password", "User 45" },
                    { 46, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1824), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1825), "password", "User 46" },
                    { 47, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1825), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1826), "password", "User 47" },
                    { 48, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1826), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1827), "password", "User 48" },
                    { 49, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1827), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1828), "password", "User 49" },
                    { 50, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1828), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1828), "password", "User 50" },
                    { 51, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1829), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1829), "password", "User 51" },
                    { 52, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1830), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1830), "password", "User 52" },
                    { 53, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1831), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1831), "password", "User 53" },
                    { 54, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1832), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1832), "password", "User 54" },
                    { 55, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1833), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1833), "password", "User 55" },
                    { 56, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1834), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1834), "password", "User 56" },
                    { 57, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1835), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1835), "password", "User 57" },
                    { 58, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1836), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1836), "password", "User 58" },
                    { 59, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1836), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1837), "password", "User 59" },
                    { 60, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1837), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1838), "password", "User 60" },
                    { 61, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1838), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1839), "password", "User 61" },
                    { 62, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1839), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1840), "password", "User 62" },
                    { 63, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1840), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1840), "password", "User 63" },
                    { 64, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1841), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1841), "password", "User 64" },
                    { 65, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1842), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1842), "password", "User 65" },
                    { 66, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1843), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1843), "password", "User 66" },
                    { 67, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1844), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1844), "password", "User 67" },
                    { 68, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1845), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1845), "password", "User 68" },
                    { 69, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1846), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1846), "password", "User 69" },
                    { 70, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1847), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1847), "password", "User 70" },
                    { 71, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1848), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1848), "password", "User 71" },
                    { 72, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1848), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1849), "password", "User 72" },
                    { 73, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1849), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1850), "password", "User 73" },
                    { 74, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1850), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1851), "password", "User 74" },
                    { 75, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1851), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1851), "password", "User 75" },
                    { 76, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1852), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1852), "password", "User 76" },
                    { 77, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1853), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1853), "password", "User 77" },
                    { 78, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1854), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1854), "password", "User 78" },
                    { 79, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1855), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1855), "password", "User 79" },
                    { 80, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1856), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1856), "password", "User 80" },
                    { 81, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1857), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1857), "password", "User 81" },
                    { 82, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1858), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1858), "password", "User 82" },
                    { 83, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1859), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1859), "password", "User 83" },
                    { 84, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1860), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1860), "password", "User 84" },
                    { 85, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1860), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1861), "password", "User 85" },
                    { 86, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1861), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1862), "password", "User 86" },
                    { 87, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1862), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1863), "password", "User 87" },
                    { 88, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1863), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1863), "password", "User 88" },
                    { 89, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1864), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1864), "password", "User 89" },
                    { 90, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1865), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1865), "password", "User 90" },
                    { 91, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1866), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1866), "password", "User 91" },
                    { 92, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1867), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1867), "password", "User 92" },
                    { 93, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1868), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1868), "password", "User 93" },
                    { 94, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1869), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1869), "password", "User 94" },
                    { 95, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1870), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1870), "password", "User 95" },
                    { 96, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1871), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1871), "password", "User 96" },
                    { 97, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1871), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1872), "password", "User 97" },
                    { 98, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1872), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1873), "password", "User 98" },
                    { 99, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1873), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1874), "password", "User 99" },
                    { 100, new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1874), "male", new DateTime(2023, 8, 27, 17, 12, 32, 423, DateTimeKind.Utc).AddTicks(1874), "password", "User 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
