using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class catalogo_Estado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profesionales_Estados_Catas",
                columns: table => new
                {
                    Profesional_Estado_Numero = table.Column<byte>(type: "tinyint", nullable: false),
                    Profesional_EstadoDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Estado_Explicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Estado_Pendiente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profesional_Estado_Nota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profesional_Estado_Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesionales_Estados_Catas", x => x.Profesional_Estado_Numero);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profesionales_Estados_Catas");
        }
    }
}
