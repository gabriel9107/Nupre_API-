using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class ProfesionalesEspecialidadesCata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "profesionalesEspecialidadesCata",
                columns: table => new
                {
                    EspecialidadNumero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialidadDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecialidadTipoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    EspecialidadProfesionNumero = table.Column<short>(type: "smallint", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesionalesEspecialidadesCata", x => x.EspecialidadNumero);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profesionalesEspecialidadesCata");
        }
    }
}
