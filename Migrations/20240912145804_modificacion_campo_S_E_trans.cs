using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class modificacion_campo_S_E_trans : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_profesionalesSolicitudesTrans_Solicitud_Numero_NavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Solicitud_Numero_NavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.DropColumn(
                name: "Solicitud_Numero_NavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.AddColumn<byte>(
                name: "Especialidad_Tipo_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Especialidad_Tipo_Numero",
                table: "Profesionales_Solicitudes_Especialidades_Trans");

            migrationBuilder.AddColumn<int>(
                name: "Solicitud_Numero_NavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_Solicitudes_Especialidades_Trans_Solicitud_Numero_NavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Solicitud_Numero_NavigationSolicitudNumero");

            migrationBuilder.AddForeignKey(
                name: "FK_Profesionales_Solicitudes_Especialidades_Trans_profesionalesSolicitudesTrans_Solicitud_Numero_NavigationSolicitudNumero",
                table: "Profesionales_Solicitudes_Especialidades_Trans",
                column: "Solicitud_Numero_NavigationSolicitudNumero",
                principalTable: "profesionalesSolicitudesTrans",
                principalColumn: "SolicitudNumero",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
