using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla de configuración donde se registran los parámetros y sus especificaciones  para  los sistemas de información, su fuente de datos son los sistemas internos de la SISALRIL en el proceso de desarrollo.
/// </summary>
public partial class SistemasParametrosConfig
{
    /// <summary>
    /// Código único que representa cada parámetro de sistema de información.
    /// </summary>
    public string ParametroCodigo { get; set; } = null!;

    /// <summary>
    /// Valor asignado al parámetro en el sistema de información.
    /// </summary>
    public string ParametroValor { get; set; } = null!;

    /// <summary>
    /// Tipo de parámetro de sistema de información.
    /// </summary>
    public string ParametroTipo { get; set; } = null!;

    /// <summary>
    /// Breve explicación del  parámetro de sistema de información.
    /// </summary>
    public string ParametroExplicacion { get; set; } = null!;

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
