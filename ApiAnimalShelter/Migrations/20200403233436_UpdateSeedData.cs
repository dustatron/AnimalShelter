using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiAnimalShelter.Migrations
{
    public partial class UpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "Img",
                value: "https://c402277.ssl.cf1.rackcdn.com/photos/18134/images/hero_small/Medium_WW226365.jpg?1574452099");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Img", "Name" },
                values: new object[] { 10, "https://upload.wikimedia.org/wikipedia/commons/e/e7/GarfieldStanding.jpg", "Lil T Bone" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Age", "Comment", "Img", "Name" },
                values: new object[] { 5, "Reads English and French", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRFvER-gcaCz8GRzG5nFlSaJJ2xBJ_JM2uIoJq2JEgsziwwqPDt&usqp=CAU", "Jar Jar" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Comment", "Img", "Name", "Type" },
                values: new object[] { "Eats Everything", "https://outwardhound.com/buzzwoof/wp-content/uploads/2017/09/Old-Pug.jpg", "Dan", "Pug" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Comment", "Img", "Name", "Type" },
                values: new object[] { 5, 11, "Can not hear.", "https://i.ytimg.com/vi/J3lK7kZ0_mk/hqdefault.jpg", "Darth Varder", "Pug" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "Img",
                value: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "Age", "Img", "Name" },
                values: new object[] { 12, "", "Larry" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "Age", "Comment", "Img", "Name" },
                values: new object[] { 12, "Eats Humans", "", "Berry" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                columns: new[] { "Comment", "Img", "Name", "Type" },
                values: new object[] { "Eats Humans", "", "Marry", "Tiger" });
        }
    }
}
