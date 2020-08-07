using Microsoft.EntityFrameworkCore.Migrations;

namespace StarGuapa.DataAccess.Migrations
{
    public partial class TablaArticulosCo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreCategoria",
                table: "Categoria");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Categoria",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    UrlImagen = table.Column<string>(nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articulo_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulo_CategoriaId",
                table: "Articulo",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Categoria");

            migrationBuilder.AddColumn<string>(
                name: "NombreCategoria",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
