namespace Nupre_API.DTOs
{
    public class Solicitudes_Actividades_Progress_DTO
    {
        public int Actividad_numero { get; set; }
        public string Actividad_descripcion { get; set; } = null!; 
        public int Proceso_Orden { get; set; }
        public int Actividad_Completa { get; set; } 
        public double Porcentaje { get; set; }
    }
}
