using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class relacion_fk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EspecialidadesCata",
                table: "Profesionales_Solicitudes_Especialidades_Trans");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EspecialidadesCata",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
