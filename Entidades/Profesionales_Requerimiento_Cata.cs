namespace Nupre_API.Entidades
{

    //Pendiente
    //Agregar documentacion de los campos 
    //cambiar nombre a Profesionales_Requisitos_Documentos_Cata 

    public partial class Profesionales_Requerimiento_Cata
    {
        public int Requerimiento_Numero { get; set; }
        public string Requerimiento_Descripcion { get; set; } = null!; 
        public int Requerimiento_Orden { get; set; }
        public string Requerimiento_Obligatorio { get; set; } = null!;
        public string Requerimiento_Fecha_Vencimiento { get; set; } = null!;
        public int Aplica_Numero { get; set; }
        public string Requerimiento_Aplica_Renovacion { get; set; } = null!;
        public string Registro_Estado { get; set; } = null!;
        public DateTime Registro_Fecha { get; set; }
    }
}
