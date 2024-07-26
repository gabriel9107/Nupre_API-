using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo con los tipos de estado civil,  según codificación de la JCE, su fuente de datos son las vistas que nos publica la TSS.
/// </summary>
public partial class TssEstadosCivilCatum
{
    /// <summary>
    /// Es el código de estado civil de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string EstadoCivilCodigo { get; set; } = null!;

    /// <summary>
    /// Es la descripción del estado civil de cada persona registrada en el padrón de ciudadanos de la TSS.
    /// </summary>
    public string EstadoCivilDescripcion { get; set; } = null!;

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
