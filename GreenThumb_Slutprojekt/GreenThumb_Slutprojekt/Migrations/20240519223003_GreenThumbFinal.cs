using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb_Slutprojekt.Migrations
{
    /// <inheritdoc />
    public partial class GreenThumbFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstructionName",
                table: "Instructions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstructionName",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 1,
                column: "InstructionName",
                value: "Vattning");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 2,
                column: "InstructionName",
                value: "Vattning");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 3,
                column: "InstructionName",
                value: "Ljus");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 4,
                column: "InstructionName",
                value: "Ljus");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 5,
                column: "InstructionName",
                value: "Ljus");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 6,
                column: "InstructionName",
                value: "Vattning");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 7,
                column: "InstructionName",
                value: "Vattning");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 8,
                column: "InstructionName",
                value: "Vattning");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 9,
                column: "InstructionName",
                value: "Vattning");

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "InstructionId",
                keyValue: 10,
                column: "InstructionName",
                value: "Ljus");
        }
    }
}
