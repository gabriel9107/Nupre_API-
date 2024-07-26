using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene el código de identificación internacional de ocupación de la OIT, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ComunesCiioCatum
{
    /// <summary>
    /// Código de ocupación del trabajador, según clasificación internacional de ocupaciones (CIIO).
    /// </summary>
    public string CiioCodigo { get; set; } = null!;

    /// <summary>
    /// Descripción de la ocupación del trabajador, según clasificación internacional de ocupaciones (CIIO).
    /// </summary>
    public string CiioDescripcion { get; set; } = null!;

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
