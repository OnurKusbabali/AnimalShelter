using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApp.Migrations
{
    public partial class animalModifyed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Animals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Animals");
        }
    }
}
