using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazingPizza.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    BasePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "BasePrice", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 9.99m, "It's cheesy and delicious. Why wouldn't you want one?", "img/pizzas/cheese.jpg", "Basic Cheese Pizza" },
                    { 2, 11.99m, "It has EVERY kind of bacon", "img/pizzas/bacon.jpg", "The Baconatorizor" },
                    { 3, 10.50m, "It's the pizza you grew up with, but Blazing hot!", "img/pizzas/pepperoni.jpg", "Classic pepperoni" },
                    { 4, 12.75m, "Spicy chicken, hot sauce and bleu cheese, guaranteed to warm you up", "img/pizzas/meaty.jpg", "Buffalo chicken" },
                    { 5, 11.00m, "It has mushrooms. Isn't that obvious?", "img/pizzas/mushroom.jpg", "Mushroom Lovers" },
                    { 6, 11.50m, "It's like salad, but on a pizza", "img/pizzas/salad.jpg", "Veggie Delight" },
                    { 7, 9.99m, "Traditional Italian pizza with tomatoes and basil", "img/pizzas/margherita.jpg", "Margherita" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
