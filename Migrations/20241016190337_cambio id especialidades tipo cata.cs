using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class cambioidespecialidadestipocata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesionales_Especialidades_Tipos_Cata",
                table: "Profesionales_Especialidades_Tipos_Cata");

            migrationBuilder.AlterColumn<int>(
                name: "Especialidad_Tipo_Numero",
                table: "Profesionales_Especialidades_Tipos_Cata",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Profesionales_Especialidades_Tipos_Cata",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesionales_Especialidades_Tipos_Cata",
                table: "Profesionales_Especialidades_Tipos_Cata",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profesionales_Especialidades_Tipos_Cata",
                table: "Profesionales_Especialidades_Tipos_Cata");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Profesionales_Especialidades_Tipos_Cata");

            migrationBuilder.AlterColumn<int>(
                name: "Especialidad_Tipo_Numero",
                table: "Profesionales_Especialidades_Tipos_Cata",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profesionales_Especialidades_Tipos_Cata",
                table: "Profesionales_Especialidades_Tipos_Cata",
                column: "Especialidad_Tipo_Numero");
        }
    }
}
