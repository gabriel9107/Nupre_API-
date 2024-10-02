namespace Nupre_API.Entidades
{
    public class Profesionales_Actividades_Tipos_Cata
    {
        public int Actividad_Numero { get; set; }
        public string Actividad_Descripcion { get; set; } = null!; 
        public string Actividad_Explicacion { get; set; } = null!;
        public int Proceso_Tipo { get; set; }
        public string Actividad_Editable { get; set; } = null!;
        public string Actividad_Proceso_Cierra { get; set; } = null!;
        public string Actividad_Requerida { get; set; } = null!;
        public string Registro_Estado { get; set; } = null!;
        public string Registro_Usuario { get; set; } = null!;
        public DateTime Registro_Fecha { get; set; }


    }
}
