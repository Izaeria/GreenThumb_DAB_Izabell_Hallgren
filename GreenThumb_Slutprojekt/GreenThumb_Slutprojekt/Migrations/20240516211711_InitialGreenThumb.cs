using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GreenThumb_Slutprojekt.Migrations
{
    /// <inheritdoc />
    public partial class InitialGreenThumb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "PlantId", "PlantName" },
                values: new object[,]
                {
                    { 1, "Gullranka" },
                    { 2, "Peperomia" }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "InstructionId", "InstructionName", "Instructions", "PlantId" },
                values: new object[,]
                {
                    { 1, "Vattning", " Håll jorden jämnt fuktig, men låt inte växten stå i vatten. Vattna när det översta lagret av jord känns torrt.", 1 },
                    { 2, "Vattning", " Håll jorden jämnt fuktig, men låt inte växten stå i vatten. Vattna när det översta lagret av jord känns torrt.", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "PlantId",
                keyValue: 2);
        }
    }
}
