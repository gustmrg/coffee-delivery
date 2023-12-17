using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeDelivery.API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coffees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    temperature = table.Column<int>(type: "INTEGER", nullable: false),
                    category = table.Column<int>(type: "INTEGER", nullable: false),
                    price = table.Column<double>(type: "REAL", nullable: false),
                    has_milk = table.Column<bool>(type: "INTEGER", nullable: false),
                    has_alcohol = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("coffee_id", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coffees");
        }
    }
}
