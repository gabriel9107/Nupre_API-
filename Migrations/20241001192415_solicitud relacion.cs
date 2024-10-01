using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class solicitudrelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.AddColumn<byte>(
                name: "SolicitudEstadoNumeroNavigationProfesional_Estado_Numero",
                table: "Profesionales_Solicitudes_Trans",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Trans_SolicitudEstadoNumeroNavigationProfesional_Estado_Numero",
                table: "Profesionales_Solicitudes_Trans",
                column: "SolicitudEstadoNumeroNavigationProfesional_Estado_Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Trans_profesionales_Estados_Catas_SolicitudEstadoNumeroNavigationProfesional_Estado_Numero",
                table: "Profesionales_Solicitudes_Trans",
                column: "SolicitudEstadoNumeroNavigationProfesional_Estado_Numero",
                principalTable: "profesionales_Estados_Catas",
                principalColumn: "Profesional_Estado_Numero",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Trans_profesionales_Estados_Catas_SolicitudEstadoNumeroNavigationProfesional_Estado_Numero",
                table: "Profesionales_Solicitudes_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Trans_SolicitudEstadoNumeroNavigationProfesional_Estado_Numero",
                table: "Profesionales_Solicitudes_Trans");

            migrationBuilder.DropColumn(
                name: "SolicitudEstadoNumeroNavigationProfesional_Estado_Numero",
                table: "Profesionales_Solicitudes_Trans");

            migrationBuilder.AddColumn<int>(
                name: "Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Profesionales_Solicitudes_TranSolicitud_Numero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_Profesionales_Solicitudes_Trans_Profesionales_Solicitudes_TranSolicitud_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Profesionales_Solicitudes_TranSolicitud_Numero",
                principalTable: "Profesionales_Solicitudes_Trans",
                principalColumn: "Solicitud_Numero");
        }
    }
}
