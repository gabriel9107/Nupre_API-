using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class actividades_Tipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales_Actividades_Tipos_Cata",
                columns: table => new
                {
                    Actividad_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actividad_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actividad_Explicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proceso_Tipo = table.Column<int>(type: "int", nullable: false),
                    Actividad_Editable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actividad_Proceso_Cierra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actividad_Requerida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Actividades_Tipos_Cata", x => x.Actividad_Numero);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionales_Actividades_Tipos_Cata");
        }
    }
}
