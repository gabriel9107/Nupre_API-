using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class Profesionales_Asociaciones_Tipo_Cata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.RenameColumn(
                name: "Asociacion",
                table: "Profesionales_Asociaciones_Catas",
                newName: "Asociacion_Nombre");

            migrationBuilder.AddColumn<int>(
                name: "Asociacion_Registro_Patronal",
                table: "Profesionales_Asociaciones_Catas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Asociacion_Registro_Patronal",
                table: "Profesionales_Asociaciones_Catas");

            migrationBuilder.RenameColumn(
                name: "Asociacion_Nombre",
                table: "Profesionales_Asociaciones_Catas",
                newName: "Asociacion");
        }
    }
}
