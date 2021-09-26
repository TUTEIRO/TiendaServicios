using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaServicios.Api.CarritoCompra.Migrations
{
    public partial class MigracionMySqlIncial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarritoSesionid",
                table: "CarritoSesion",
                newName: "CarritoSesionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarritoSesionId",
                table: "CarritoSesion",
                newName: "CarritoSesionid");
        }
    }
}
