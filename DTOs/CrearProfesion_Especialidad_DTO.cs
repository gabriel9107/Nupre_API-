namespace Nupre_API.DTOs
{
    public class CrearProfesion_Especialidad_DTO
    {
        public int Solicitud_Numero { get; set; }

        /// <summary>
        /// Numero de la especialidad médica. 
        /// </summary>
        public short Especialidad_Numero { get; set; }

        public string Especialidad_Periodo { get; set; }

        public string? Documento_Codigo { get; set; }

        
        public byte Especialidad_Estado_Numero { get; set; }

        public DateTime Especialidad_Estado_Fecha { get; set; }

        public short? Disposicion_Numero { get; set; }

        //public IFormFile? documento {  get; set; } = null!;


        //



        //public string Especialidad_Estado_Nota { get; set; } = null!;

        //public short Disposicion_Numero { get; set; }

        //public byte Motivo_Numero { get; set; }


        //public string Registro_Estado { get; set; } = null!;

        //public string Registro_Usuario { get; set; } = null!;


        //public DateTime Registro_Fecha { get; set; }

    }
}
