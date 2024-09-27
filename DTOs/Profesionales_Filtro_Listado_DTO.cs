namespace Nupre_API.DTOs
{
    public class Profesionales_Filtro_Listado_DTO : FiltroBase
    {
        public int? Empleador_Registro_Patronal { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public int? Estado_Numero { get; set; }
        public DateTime? AnioInicio { get; set; }
        public DateTime? AnioFin { get; set; }
        public string? Solicitud_Numero { get; set; }
    }

}
