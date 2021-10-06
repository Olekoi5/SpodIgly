using Microsoft.EntityFrameworkCore.Migrations;

namespace SpodIglyMVC.Migrations
{
    public partial class ModelsToDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CovertFileName",
                table: "Albums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CovertFileName",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
