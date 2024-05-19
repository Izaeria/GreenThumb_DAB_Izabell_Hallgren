using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb_Slutprojekt.Migrations
{
    /// <inheritdoc />
    public partial class GreenThumbTest2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2,
                column: "Instructions",
                value: " Låt jorden torka något mellan vattningar. Undvik övervattning och låt inte växten stå i vatten.");

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "PlantName" },
                values: new object[,]
                {
                    { 3, "Fredskalla" },
                    { 4, "Porslinsblomma" },
                    { 5, "Syngonium" },
                    { 6, "Monstera" },
                    { 7, "Begonia" },
                    { 8, "Ficus elastica " },
                    { 9, "Aloe Vera" },
                    { 10, "Tradescantia" }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "InstructionId", "InstructionName", "Instructions", "PlantId" },
                values: new object[,]
                {
                    { 3, "Ljus", "Trivs bäst i indirekt solljus eller skuggiga områden.", 3 },
                    { 4, "Ljus", "Placera på en ljus plats med indirekt solljus.", 4 },
                    { 5, "Ljus", "Trivs i ljusa till delvis skuggiga områden.", 5 },
                    { 6, "Vattning", " Låt jorden torka något mellan vattningar. Undvik att övervattna.", 6 },
                    { 7, "Vattning", "Håll jorden fuktig, men undvik övervattning. Vattna när det översta lagret av jord känns torrt.", 7 },
                    { 8, "Vattning", " Håll jorden fuktig under sommaren och låt sedan torka något mellan vattningar under vintern.", 8 },
                    { 9, "Vattning", "Låt jorden torka helt mellan vattningar. Vattna sparsamt och undvik övervattning.", 9 },
                    { 10, "Ljus", "Trivs i ljusa till delvis skuggiga områden.", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2,
                column: "Instructions",
                value: " Håll jorden jämnt fuktig, men låt inte växten stå i vatten. Vattna när det översta lagret av jord känns torrt.");
        }
    }
}
