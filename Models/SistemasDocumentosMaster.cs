using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un maestro donde se registran todo los documentos que se publican a los usuarios para los diferentes sistemas de información, su fuente de datos los sistemas internos de la SISALRIL.
/// </summary>
public partial class SistemasDocumentosMaster
{
    /// <summary>
    /// Es el código único que representa el documento dentro del sistema.
    /// </summary>
    public short DocumentoCodigo { get; set; }

    /// <summary>
    /// Nombre del documento  (Esquema, Instructivo, formato) que se publica a los usuarios.
    /// </summary>
    public string DocumentoNombre { get; set; } = null!;

    /// <summary>
    /// Categoría  del documento  (Esquema, Instructivo, formato) que se publica a los usuarios.
    /// </summary>
    public string DocumentoCategoria { get; set; } = null!;

    /// <summary>
    /// Breve descripción del documento  (Esquema, Instructivo, formato) que se publica a los usuarios.
    /// </summary>
    public string DocumentoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación del documento  (Esquema, Instructivo, formato) que se publica a los usuarios.
    /// </summary>
    public string DocumentoExplicacion { get; set; } = null!;

    /// <summary>
    /// Es la ruta del servidor y carpeta donde se encuentra almacenado el documento.
    /// </summary>
    public string DocumentoRuta { get; set; } = null!;

    /// <summary>
    /// Representa el estado en que se encuentra un registro en una tabla (A=Activo, I=Inactivo).
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Indica el usuario que ejecutó la operación de insertar o actualizar un registro en una tabla.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFecha { get; set; }
}
