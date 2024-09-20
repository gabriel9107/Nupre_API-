using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class documento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Documento_ruta",
                table: "Profesionales_Documento_Masters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Tipo_Documento",
                table: "Profesionales_Documento_Masters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento_ruta",
                table: "Profesionales_Documento_Masters");

            migrationBuilder.DropColumn(
                name: "Tipo_Documento",
                table: "Profesionales_Documento_Masters");
        }
    }
}
