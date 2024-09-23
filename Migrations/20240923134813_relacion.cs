using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class relacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EspecialidadesCata",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Especialidades_CataEspecialidad_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Especialidades_CataEspecialidad_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Especialidades_CataEspecialidad_Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Especialidades_Cata_Especialidades_CataEspecialidad_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Especialidades_CataEspecialidad_Numero",
                principalTable: "Profesionales_Especialidades_Cata",
                principalColumn: "Especialidad_Numero",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Especialidades_Cata_Especialidades_CataEspecialidad_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Especialidades_CataEspecialidad_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "EspecialidadesCata",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "Especialidades_CataEspecialidad_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");
        }
    }
}
