namespace Nupre_API.DTOs
{
    public class DetalleProfesionales_DTO
    {
        public int? Id { get; set;   }
        public int Solicitud_Numero { get; set; }
        public string Especialidad_Descripcion { get; set; }
        public string Registro_Estado { get; set; }

        public DateTime Registro_Fecha {  get; set; }   
        public string Especialidad_Periodo { get; set; }
        public int Especialidad_Tipo_Numero { get; set; }

        public int Especialidad_Numero {get; set; }

    }
}
