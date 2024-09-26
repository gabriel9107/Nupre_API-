using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class localidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales_Solicitudes_Localidades_Trans",
                columns: table => new
                {
                    Solicitud_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Localidad_Secuencia = table.Column<int>(type: "int", nullable: false),
                    Prestadora_Numero = table.Column<int>(type: "int", nullable: false),
                    Municipio_Numero = table.Column<short>(type: "smallint", nullable: false),
                    Localidad_Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Telefono1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Telefono2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad_Prestadora_Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Solicitudes_Localidades_Trans", x => x.Solicitud_Numero);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionales_Solicitudes_Localidades_Trans");
        }
    }
}
