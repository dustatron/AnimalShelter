using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnimalShelter.Migrations
{
    public partial class AddSeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Comment", "Img", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 12, "Eats Humans", "", "Jerry", "Tiger" },
                    { 2, 12, "Eats Humans", "", "Larry", "Tiger" },
                    { 3, 12, "Eats Humans", "", "Berry", "Tiger" },
                    { 4, 12, "Eats Humans", "", "Marry", "Tiger" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);
        }
    }
}
