namespace Nupre_API.Entidades
{
    public partial class Profesionales_Especialidades_Cata
    {/// <summary>
     /// Numero de la especialidad médica
     /// </summary>
        public int Especialidad_Numero { get; set; }
        /// <summary>
        /// Descripción de la especialidad médica.
        /// </summary>
        public string Especialidad_Descripcion { get; set; } = null!;
    
        public int Especialidad_Tipo_Numero { get; set; }
      
        public int Especialidad_Profesion_Numero { get; set; }

        /// <summary>
        /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
        /// </summary>
        public string Registro_Estado { get; set; } = null!;
        public string Registro_Usuario { get; set; } = null!;
        public DateTime Registro_Fecha { get; set; }
    }
}
