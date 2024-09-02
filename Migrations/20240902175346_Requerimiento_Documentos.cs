using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class Requerimiento_Documentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales_Documento_Masters",
                columns: table => new
                {
                    Documento_Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Documento_Masters", x => x.Documento_Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Requerimientos_Cata",
                columns: table => new
                {
                    Requerimiento_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requerimiento_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requerimiento_Orden = table.Column<int>(type: "int", nullable: false),
                    Requerimiento_Obligatorio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requerimiento_Fecha_Vencimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aplica_Numero = table.Column<int>(type: "int", nullable: false),
                    Requerimiento_Aplica_Renovacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Requerimientos_Cata", x => x.Requerimiento_Numero);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionales_Documento_Masters");

            migrationBuilder.DropTable(
                name: "Profesionales_Requerimientos_Cata");
        }
    }
}
