namespace Nupre_API.Entidades
{

    public partial class TSSNacionalidadesCata
    {
        /// <summary>
        /// Número único que representa la nacionalidad de la persona o afiliado.
        /// </summary>
        public int Nacionalidad_Numero { get; set; }
        /// <summary>
        /// Descripción de la nacionalidad de la persona o afiliado.
        /// </summary>
        public string Nacionalidad_Descripcion { get; set; } = null!;
        /// <summary>
        /// Es el nombre del pais correspondiente a la nacionalidad de la persona o afiliado..
        /// </summary>
        public string Nacionalidad_Pais_Nombre { get; set; } = null!;

        /// <summary>
        /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
        /// </summary>
        public string Registro_Estado { get; set; } = null!;
        /// <summary>
        /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
        /// </summary>
        public string Registro_Usuario { get; set; } = null!;

        /// <summary>
        /// Indica la fecha de cuando se insertó o se actualizó un registro en la tabla .
        /// </summary>
        public DateTime Registro_Fecha { get; set; }


    }
}
