using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarGuapa.DataAccess.Migrations
{
    public partial class Ordermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    CalleCampo1 = table.Column<string>(nullable: false),
                    CalleCampo2 = table.Column<string>(nullable: false),
                    CalleCampo3 = table.Column<string>(nullable: false),
                    TipoInmueble = table.Column<string>(nullable: true),
                    TipoInmuebleDesc = table.Column<string>(nullable: true),
                    BloqueInterior = table.Column<string>(nullable: true),
                    BloqueOInteriorDesc = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: false),
                    Ciudad = table.Column<string>(nullable: false),
                    Barrio = table.Column<string>(maxLength: 80, nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true),
                    OrdenTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrdenFecha = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdenId = table.Column<int>(nullable: false),
                    articuloId = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenDetalle_Orden_OrdenId",
                        column: x => x.OrdenId,
                        principalTable: "Orden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDetalle_Articulo_articuloId",
                        column: x => x.articuloId,
                        principalTable: "Articulo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalle_OrdenId",
                table: "OrdenDetalle",
                column: "OrdenId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDetalle_articuloId",
                table: "OrdenDetalle",
                column: "articuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenDetalle");

            migrationBuilder.DropTable(
                name: "Orden");
        }
    }
}
