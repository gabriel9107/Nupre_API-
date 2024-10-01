namespace Nupre_API.DTOs
{
    public class CrearSolicitudes_ActividadesDTO
    {
        public int Actividad_Secuencia { get; set; }
        public int Solicitud_Numero { get; set; }
        public int Solicitud_Tipo_Numero { get; set; }
        public int Actividad_Numero { get; set; }
        public DateTime Actividad_Fecha { get; set; }
        public string Actividad_Contenido { get; set; }
        public int Sometimiento_Secuencia { get; set; }
    }
}
