namespace Nupre_API.Entidades
{
    public partial class Profesionales_Documento_Master
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int Documento_Codigo { get; set; }
        /// <summary>
        /// Es el numero de solcitud
        /// </summary>
        public int Solicitud_Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        /// <summary>
        /// 1 Cedula 
        /// 2 Execquatur 
        /// 3 
        /// </summary>
        public int Tipo_Documento { get; set; }

        public string Documento_ruta { get; set; }
        public string Registro_Estado { get; set; }
        public string Registro_Usuario { get; set; }

        public DateTime Registro_Fecha { get; set; }

    }
}
