using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla de configuración donde se registran los objetos de las ayudas de los módulos de los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL en el proceso de desarrollo.
/// </summary>
public partial class SistemasAyudasConfig
{
    /// <summary>
    /// Numero único de control de la ayuda de la interface u operación del sistema de información.
    /// </summary>
    public string AyudaControlId { get; set; } = null!;

    /// <summary>
    /// Mensaje corto de la ayuda de la interface u operación del sistema de información.
    /// </summary>
    public string AyudaMensajeCorto { get; set; } = null!;

    /// <summary>
    /// Mensaje largo de la ayuda de la interface u operación del sistema de información.
    /// </summary>
    public string AyudaMensajeLargo { get; set; } = null!;

    /// <summary>
    /// Dirección y nombre de la imagen de la ayuda de la interface u operación del sistema de información.
    /// </summary>
    public string AyudaImagenUrl { get; set; } = null!;

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
