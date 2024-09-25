using Nupre_API.Migrations;

namespace Nupre_API.DTOs
{
    public class CrearAsociacion_DTO
    {
        public int Solicitud_Numero { get; set; }

        public int Asociacion_Registro_Patronal { get; set; }

        public string Profesional_Asociacion_Codigo { get; set; } = null!;
         
        public IFormFile Documento { get; set; }


    }
}
