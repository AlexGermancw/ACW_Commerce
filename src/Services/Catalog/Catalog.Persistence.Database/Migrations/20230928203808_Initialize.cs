using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Catalog.Persistence.Database.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductInStockId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Stock_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Product",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Prodcut 1", 716.02m },
                    { 2, "Description for product 2", "Prodcut 2", 865.09m },
                    { 3, "Description for product 3", "Prodcut 3", 926.47m },
                    { 4, "Description for product 4", "Prodcut 4", 376.61m },
                    { 5, "Description for product 5", "Prodcut 5", 530.53m },
                    { 6, "Description for product 6", "Prodcut 6", 947.15m },
                    { 7, "Description for product 7", "Prodcut 7", 655.57m },
                    { 8, "Description for product 8", "Prodcut 8", 280.07m },
                    { 9, "Description for product 9", "Prodcut 9", 215.49m },
                    { 10, "Description for product 10", "Prodcut 10", 691.71m },
                    { 11, "Description for product 11", "Prodcut 11", 468.64m },
                    { 12, "Description for product 12", "Prodcut 12", 100.39m },
                    { 13, "Description for product 13", "Prodcut 13", 961.38m },
                    { 14, "Description for product 14", "Prodcut 14", 380.56m },
                    { 15, "Description for product 15", "Prodcut 15", 478.3m },
                    { 16, "Description for product 16", "Prodcut 16", 362.04m },
                    { 17, "Description for product 17", "Prodcut 17", 614.46m },
                    { 18, "Description for product 18", "Prodcut 18", 404.3m },
                    { 19, "Description for product 19", "Prodcut 19", 272.5m },
                    { 20, "Description for product 20", "Prodcut 20", 101.71m },
                    { 21, "Description for product 21", "Prodcut 21", 300.84m },
                    { 22, "Description for product 22", "Prodcut 22", 686.55m },
                    { 23, "Description for product 23", "Prodcut 23", 796.54m },
                    { 24, "Description for product 24", "Prodcut 24", 851.96m },
                    { 25, "Description for product 25", "Prodcut 25", 107.7m },
                    { 26, "Description for product 26", "Prodcut 26", 950.79m },
                    { 27, "Description for product 27", "Prodcut 27", 809.34m },
                    { 28, "Description for product 28", "Prodcut 28", 486.71m },
                    { 29, "Description for product 29", "Prodcut 29", 660.58m },
                    { 30, "Description for product 30", "Prodcut 30", 314.25m },
                    { 31, "Description for product 31", "Prodcut 31", 876.15m },
                    { 32, "Description for product 32", "Prodcut 32", 975.73m },
                    { 33, "Description for product 33", "Prodcut 33", 972.2m },
                    { 34, "Description for product 34", "Prodcut 34", 138.85m },
                    { 35, "Description for product 35", "Prodcut 35", 365.43m },
                    { 36, "Description for product 36", "Prodcut 36", 323.02m },
                    { 37, "Description for product 37", "Prodcut 37", 412.59m },
                    { 38, "Description for product 38", "Prodcut 38", 589.15m },
                    { 39, "Description for product 39", "Prodcut 39", 587.05m },
                    { 40, "Description for product 40", "Prodcut 40", 736.03m },
                    { 41, "Description for product 41", "Prodcut 41", 592.57m },
                    { 42, "Description for product 42", "Prodcut 42", 416.72m },
                    { 43, "Description for product 43", "Prodcut 43", 393.57m },
                    { 44, "Description for product 44", "Prodcut 44", 863.97m },
                    { 45, "Description for product 45", "Prodcut 45", 553.65m },
                    { 46, "Description for product 46", "Prodcut 46", 863.93m },
                    { 47, "Description for product 47", "Prodcut 47", 960.66m },
                    { 48, "Description for product 48", "Prodcut 48", 858.94m },
                    { 49, "Description for product 49", "Prodcut 49", 475.67m },
                    { 50, "Description for product 50", "Prodcut 50", 734.55m },
                    { 51, "Description for product 51", "Prodcut 51", 963.9m },
                    { 52, "Description for product 52", "Prodcut 52", 423.82m },
                    { 53, "Description for product 53", "Prodcut 53", 322.75m },
                    { 54, "Description for product 54", "Prodcut 54", 716.07m },
                    { 55, "Description for product 55", "Prodcut 55", 961.83m },
                    { 56, "Description for product 56", "Prodcut 56", 914.9m },
                    { 57, "Description for product 57", "Prodcut 57", 382.47m },
                    { 58, "Description for product 58", "Prodcut 58", 710.64m },
                    { 59, "Description for product 59", "Prodcut 59", 423.05m },
                    { 60, "Description for product 60", "Prodcut 60", 442.37m },
                    { 61, "Description for product 61", "Prodcut 61", 218.01m },
                    { 62, "Description for product 62", "Prodcut 62", 396.35m },
                    { 63, "Description for product 63", "Prodcut 63", 168.12m },
                    { 64, "Description for product 64", "Prodcut 64", 357.47m },
                    { 65, "Description for product 65", "Prodcut 65", 816.11m },
                    { 66, "Description for product 66", "Prodcut 66", 627.52m },
                    { 67, "Description for product 67", "Prodcut 67", 199.01m },
                    { 68, "Description for product 68", "Prodcut 68", 885.12m },
                    { 69, "Description for product 69", "Prodcut 69", 429.89m },
                    { 70, "Description for product 70", "Prodcut 70", 973.5m },
                    { 71, "Description for product 71", "Prodcut 71", 301.28m },
                    { 72, "Description for product 72", "Prodcut 72", 647.35m },
                    { 73, "Description for product 73", "Prodcut 73", 114.5m },
                    { 74, "Description for product 74", "Prodcut 74", 850.41m },
                    { 75, "Description for product 75", "Prodcut 75", 448.51m },
                    { 76, "Description for product 76", "Prodcut 76", 571.16m },
                    { 77, "Description for product 77", "Prodcut 77", 811.32m },
                    { 78, "Description for product 78", "Prodcut 78", 212.79m },
                    { 79, "Description for product 79", "Prodcut 79", 924.88m },
                    { 80, "Description for product 80", "Prodcut 80", 667.77m },
                    { 81, "Description for product 81", "Prodcut 81", 858.4m },
                    { 82, "Description for product 82", "Prodcut 82", 933.14m },
                    { 83, "Description for product 83", "Prodcut 83", 478.91m },
                    { 84, "Description for product 84", "Prodcut 84", 897.5m },
                    { 85, "Description for product 85", "Prodcut 85", 252.76m },
                    { 86, "Description for product 86", "Prodcut 86", 811.27m },
                    { 87, "Description for product 87", "Prodcut 87", 464.54m },
                    { 88, "Description for product 88", "Prodcut 88", 201.11m },
                    { 89, "Description for product 89", "Prodcut 89", 233.44m },
                    { 90, "Description for product 90", "Prodcut 90", 309.21m },
                    { 91, "Description for product 91", "Prodcut 91", 824.59m },
                    { 92, "Description for product 92", "Prodcut 92", 976.27m },
                    { 93, "Description for product 93", "Prodcut 93", 819.3m },
                    { 94, "Description for product 94", "Prodcut 94", 488.29m },
                    { 95, "Description for product 95", "Prodcut 95", 916.31m },
                    { 96, "Description for product 96", "Prodcut 96", 511.38m },
                    { 97, "Description for product 97", "Prodcut 97", 848m },
                    { 98, "Description for product 98", "Prodcut 98", 638.67m },
                    { 99, "Description for product 99", "Prodcut 99", 625.54m },
                    { 100, "Description for product 100", "Prodcut 100", 322.92m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stock",
                columns: new[] { "ProductId", "ProductInStockId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 5 },
                    { 2, 2, 35 },
                    { 3, 3, 21 },
                    { 4, 4, 2 },
                    { 5, 5, 23 },
                    { 6, 6, 35 },
                    { 7, 7, 18 },
                    { 8, 8, 35 },
                    { 9, 9, 27 },
                    { 10, 10, 27 },
                    { 11, 11, 48 },
                    { 12, 12, 47 },
                    { 13, 13, 13 },
                    { 14, 14, 18 },
                    { 15, 15, 42 },
                    { 16, 16, 15 },
                    { 17, 17, 38 },
                    { 18, 18, 28 },
                    { 19, 19, 1 },
                    { 20, 20, 48 },
                    { 21, 21, 35 },
                    { 22, 22, 15 },
                    { 23, 23, 26 },
                    { 24, 24, 2 },
                    { 25, 25, 7 },
                    { 26, 26, 44 },
                    { 27, 27, 12 },
                    { 28, 28, 11 },
                    { 29, 29, 32 },
                    { 30, 30, 34 },
                    { 31, 31, 41 },
                    { 32, 32, 47 },
                    { 33, 33, 44 },
                    { 34, 34, 35 },
                    { 35, 35, 9 },
                    { 36, 36, 14 },
                    { 37, 37, 6 },
                    { 38, 38, 47 },
                    { 39, 39, 32 },
                    { 40, 40, 24 },
                    { 41, 41, 1 },
                    { 42, 42, 10 },
                    { 43, 43, 35 },
                    { 44, 44, 14 },
                    { 45, 45, 12 },
                    { 46, 46, 38 },
                    { 47, 47, 14 },
                    { 48, 48, 26 },
                    { 49, 49, 46 },
                    { 50, 50, 12 },
                    { 51, 51, 11 },
                    { 52, 52, 43 },
                    { 53, 53, 15 },
                    { 54, 54, 6 },
                    { 55, 55, 15 },
                    { 56, 56, 39 },
                    { 57, 57, 48 },
                    { 58, 58, 17 },
                    { 59, 59, 2 },
                    { 60, 60, 9 },
                    { 61, 61, 15 },
                    { 62, 62, 37 },
                    { 63, 63, 17 },
                    { 64, 64, 49 },
                    { 65, 65, 19 },
                    { 66, 66, 14 },
                    { 67, 67, 20 },
                    { 68, 68, 5 },
                    { 69, 69, 15 },
                    { 70, 70, 14 },
                    { 71, 71, 10 },
                    { 72, 72, 47 },
                    { 73, 73, 43 },
                    { 74, 74, 14 },
                    { 75, 75, 33 },
                    { 76, 76, 19 },
                    { 77, 77, 8 },
                    { 78, 78, 14 },
                    { 79, 79, 9 },
                    { 80, 80, 5 },
                    { 81, 81, 7 },
                    { 82, 82, 21 },
                    { 83, 83, 7 },
                    { 84, 84, 22 },
                    { 85, 85, 40 },
                    { 86, 86, 25 },
                    { 87, 87, 48 },
                    { 88, 88, 16 },
                    { 89, 89, 18 },
                    { 90, 90, 36 },
                    { 91, 91, 42 },
                    { 92, 92, 1 },
                    { 93, 93, 33 },
                    { 94, 94, 9 },
                    { 95, 95, 49 },
                    { 96, 96, 46 },
                    { 97, 97, 45 },
                    { 98, 98, 32 },
                    { 99, 99, 43 },
                    { 100, 100, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductId",
                schema: "Catalog",
                table: "Product",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stock",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Catalog");
        }
    }
}
