using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class tablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales_Especialidades_Cata",
                columns: table => new
                {
                    Especialidad_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad_Tipo_Numero = table.Column<int>(type: "int", nullable: false),
                    Especialidad_Profesion_Numero = table.Column<int>(type: "int", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Especialidades_Cata", x => x.Especialidad_Numero);
                });

            migrationBuilder.CreateTable(
                name: "Profesionales_Especialidades_Tipos_Cata",
                columns: table => new
                {
                    Especialidad_Tipo_Numero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especialidad_Tipo_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad_Tipo_Explicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Registro_Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales_Especialidades_Tipos_Cata", x => x.Especialidad_Tipo_Numero);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionales_Especialidades_Cata");

            migrationBuilder.DropTable(
                name: "Profesionales_Especialidades_Tipos_Cata");
        }
    }
}
