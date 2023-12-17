using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                    coffee_id = table.Column<int>(type: "INTEGER", nullable: false)
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
                    table.PrimaryKey("coffee_id", x => x.coffee_id);
                });

            migrationBuilder.InsertData(
                table: "coffees",
                columns: new[] { "coffee_id", "category", "description", "has_alcohol", "has_milk", "name", "price", "temperature" },
                values: new object[,]
                {
                    { 1, 1, "O tradicional café feito com água quente e grãos moídos", false, false, "Expresso Tradicional", 9.9000000000000004, 1 },
                    { 2, 1, "Expresso diluído, menos intenso que o tradicional", false, false, "Expresso Americano", 9.9000000000000004, 1 },
                    { 3, 1, "Café expresso tradicional com espuma cremosa", false, false, "Expresso Cremoso", 9.9000000000000004, 1 },
                    { 4, 1, "Meio a meio expresso tradicional com leite vaporizado", false, true, "Café com Leite", 9.9000000000000004, 1 },
                    { 5, 1, "Uma dose de café expresso com o dobro de leite e espuma cremosa", false, true, "Latte", 9.9000000000000004, 1 },
                    { 6, 1, "Bebida com canela feita de doses iguais de café, leite e espuma", false, true, "Capuccino", 9.9000000000000004, 1 },
                    { 7, 1, "Café expresso com calda de chocolate, pouco leite e espuma", false, true, "Mocaccino", 9.9000000000000004, 1 },
                    { 8, 2, "Bebida feita com chocolate dissolvido no leite quente e café", false, true, "Chocolate Quente", 9.9000000000000004, 1 },
                    { 9, 2, "Drink gelado de café expresso com rum, creme de leite e hortelã", true, false, "Cubano", 9.9000000000000004, 2 },
                    { 10, 2, "Bebida preparada com grãos de café árabe e especiarias", false, false, "Árabe", 9.9000000000000004, 1 },
                    { 11, 2, "Bebida a base de café, uísque irlandês, açúcar e chantilly", true, false, "Irlandês", 9.9000000000000004, 1 }
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
