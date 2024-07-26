using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es una tabla en la cual se registran los posibles errores que los sistemas pueden generar y los cuales están controlados, en la misma se ofrece una ayuda básica al usuario para que pueda realizar su operación sin generar el mismo error nuevamente.
/// </summary>
public partial class SistemasErroresCatum
{
    public int SistemasErrorSecuencia { get; set; }

    public string SistemasErrorDescripcion { get; set; } = null!;

    public string SistemasErrorExplicacion { get; set; } = null!;

    public string SistemasErrorAyuda { get; set; } = null!;

    public string SistemasErrorMensajeInterno { get; set; } = null!;

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
