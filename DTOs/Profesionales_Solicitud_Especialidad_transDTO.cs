namespace Nupre_API.DTOs
{
    public class Profesionales_Solicitud_Especialidad_transDTO
    {
        public int Solicitud_Numero { get; set; }

        public short Especialidad_Numero { get; set; }

        public int Especialidad_Periodo { get; set; }

        public string Documento_Codigo { get; set; } = null!;
    }
}
