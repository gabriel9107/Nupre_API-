using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nupre_API.Migrations
{
    /// <inheritdoc />
    public partial class cambioNombreTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comunesMunicipiosCata_comunesProvinciasCata_ComunesProvinciasCatumProvinciaNumero",
                table: "comunesMunicipiosCata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comunesProvinciasCata",
                table: "comunesProvinciasCata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_comunesMunicipiosCata",
                table: "comunesMunicipiosCata");

            migrationBuilder.RenameTable(
                name: "comunesProvinciasCata",
                newName: "Comunes_Provincias_Cata");

            migrationBuilder.RenameTable(
                name: "comunesMunicipiosCata",
                newName: "Comunes_Municipios_Cata");

            migrationBuilder.RenameIndex(
                name: "IX_comunesMunicipiosCata_ComunesProvinciasCatumProvinciaNumero",
                table: "Comunes_Municipios_Cata",
                newName: "IX_Comunes_Municipios_Cata_ComunesProvinciasCatumProvinciaNumero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comunes_Provincias_Cata",
                table: "Comunes_Provincias_Cata",
                column: "ProvinciaNumero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comunes_Municipios_Cata",
                table: "Comunes_Municipios_Cata",
                column: "MunicipioNumero");

            migrationBuilder.AddForeignKey(
                name: "FK_Comunes_Municipios_Cata_Comunes_Provincias_Cata_ComunesProvinciasCatumProvinciaNumero",
                table: "Comunes_Municipios_Cata",
                column: "ComunesProvinciasCatumProvinciaNumero",
                principalTable: "Comunes_Provincias_Cata",
                principalColumn: "ProvinciaNumero");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comunes_Municipios_Cata_Comunes_Provincias_Cata_ComunesProvinciasCatumProvinciaNumero",
                table: "Comunes_Municipios_Cata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comunes_Provincias_Cata",
                table: "Comunes_Provincias_Cata");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comunes_Municipios_Cata",
                table: "Comunes_Municipios_Cata");

            migrationBuilder.RenameTable(
                name: "Comunes_Provincias_Cata",
                newName: "comunesProvinciasCata");

            migrationBuilder.RenameTable(
                name: "Comunes_Municipios_Cata",
                newName: "comunesMunicipiosCata");

            migrationBuilder.RenameIndex(
                name: "IX_Comunes_Municipios_Cata_ComunesProvinciasCatumProvinciaNumero",
                table: "comunesMunicipiosCata",
                newName: "IX_comunesMunicipiosCata_ComunesProvinciasCatumProvinciaNumero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comunesProvinciasCata",
                table: "comunesProvinciasCata",
                column: "ProvinciaNumero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_comunesMunicipiosCata",
                table: "comunesMunicipiosCata",
                column: "MunicipioNumero");

            migrationBuilder.AddForeignKey(
                name: "FK_comunesMunicipiosCata_comunesProvinciasCata_ComunesProvinciasCatumProvinciaNumero",
                table: "comunesMunicipiosCata",
                column: "ComunesProvinciasCatumProvinciaNumero",
                principalTable: "comunesProvinciasCata",
                principalColumn: "ProvinciaNumero");
        }
    }
}
