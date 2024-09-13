using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class prueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SolicitudNumeroNavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_SolicitudNumeroNavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "SolicitudNumeroNavigationSolicitudNumero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_profesionalesSolicitudesTrans_SolicitudNumeroNavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "SolicitudNumeroNavigationSolicitudNumero",
                principalTable: "profesionalesSolicitudesTrans",
                principalColumn: "SolicitudNumero",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_profesionalesSolicitudesTrans_SolicitudNumeroNavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_SolicitudNumeroNavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "SolicitudNumeroNavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");
        }
    }
}
