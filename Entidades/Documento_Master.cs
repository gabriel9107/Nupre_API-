namespace Nupre_API.Entidades
{
    public partial class Profesionales_Documento_Master
    {
        public int Documento_Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Registro_Estado { get; set; }
        public string Registro_Usuario { get; set; }

        public DateTime Registro_Fecha { get; set; }

    }
}
