using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class tablasprofe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "profesionalesEspecialidadesCata");

            migrationBuilder.AlterColumn<byte>(
                name: "Especialidad_Tipo_Numero",
                table: "Profesionales_Especialidades_Cata",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<short>(
                name: "Especialidad_Profesion_Numero",
                table: "Profesionales_Especialidades_Cata",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Especialidad_Tipo_Numero",
                table: "Profesionales_Especialidades_Cata",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "Especialidad_Profesion_Numero",
                table: "Profesionales_Especialidades_Cata",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.CreateTable(
                name: "profesionalesEspecialidadesCata",
                columns: table => new
                {
                    EspecialidadNumero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialidadDescripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspecialidadProfesionNumero = table.Column<short>(type: "smallint", nullable: false),
                    EspecialidadTipoNumero = table.Column<byte>(type: "tinyint", nullable: false),
                    RegistroEstado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistroUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profesionalesEspecialidadesCata", x => x.EspecialidadNumero);
                });
        }
    }
}
