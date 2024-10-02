using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class solicitudes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profesional_Documento",
                table: "Profesionales_Solicitudes_Trans");

            migrationBuilder.AddColumn<string>(
                name: "Profesional_Cedula",
                table: "Profesionales_Solicitudes_Trans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Profesional_Documento_Cedula_Numero",
                table: "Profesionales_Solicitudes_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Profesional_Exequatur_Numero",
                table: "Profesionales_Solicitudes_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profesional_Cedula",
                table: "Profesionales_Solicitudes_Trans");

            migrationBuilder.DropColumn(
                name: "Profesional_Documento_Cedula_Numero",
                table: "Profesionales_Solicitudes_Trans");

            migrationBuilder.DropColumn(
                name: "Profesional_Exequatur_Numero",
                table: "Profesionales_Solicitudes_Trans");

            migrationBuilder.AddColumn<string>(
                name: "Profesional_Documento",
                table: "Profesionales_Solicitudes_Trans",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
