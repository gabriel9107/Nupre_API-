namespace Nupre_API.Entidades
{
    public partial class Profesionales_Especialidades_Tipos_Cata
    {
        public int Id { get; set; }
        public int Especialidad_Tipo_Numero { get; set; }
        public string Especialidad_Tipo_Descripcion { get; set; }
        public string Especialidad_Tipo_Explicacion { get; set; }
        public string Registro_Estado { get; set; }
        public string Registro_Usuario { get; set; }
        public DateTime Registro_Fecha { get; set; }

    }
}
