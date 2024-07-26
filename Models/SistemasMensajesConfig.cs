using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla de configuración donde se registran los mensajes utilizados en los módulos de los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL en el proceso de desarrollo.
/// </summary>
public partial class SistemasMensajesConfig
{
    /// <summary>
    /// Código que representa los mensajes utilizados en la interfaces de los sistemas de información.
    /// </summary>
    public string CatalogoMensajeCodigo { get; set; } = null!;

    /// <summary>
    /// Contenido de los mensajes utilizados en la interfaces de los sistemas de información.
    /// </summary>
    public string CatalogoMensajeValor { get; set; } = null!;

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
