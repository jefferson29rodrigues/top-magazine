using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMagazine.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId)"+
                "Values('Caderno', 7.55, 'descrição', 10, 'caderno1.jpg', 1)");

            migrationBuilder.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                "Values('Caderno2', 7.52, 'descrição2', 12, 'caderno2.jpg', 2)");

            migrationBuilder.Sql("Insert into Products(Name, Price, Description, Stock, ImageUrl, CategoryId)" +
                "Values('Caderno3', 7.53, 'descrição3', 13, 'caderno3.jpg', 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Products");
        }
    }
}
