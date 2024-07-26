using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

/// <summary>
/// Es un catálogo que contiene tipo de reclamaciones notificaciones,  utilizado por la ARL para reportar los detalles de los pagos derivados de prestaciones de salud, su fuente de datos son los sistemas internos de la SISALRIL.
/// </summary>
public partial class ArlReclamacionesNotificacionesTipoCatum
{
    /// <summary>
    /// Tipo de notificación número de una reclamación por pago derivado de prestación de salud.
    /// </summary>
    public byte ReclamacionNotificacionTipoNumero { get; set; }

    /// <summary>
    /// Descripción del Tipo de notificación número de una reclamación por pago derivado de prestación de salud.
    /// </summary>
    public string ReclamacionNotificacionTipoDescripcion { get; set; } = null!;

    /// <summary>
    /// Explicación de la descripción del Tipo de notificación número de una reclamación por pago derivado de prestación de salud.
    /// </summary>
    public string ReclamacionNotificacionTipoExplicacion { get; set; } = null!;

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
