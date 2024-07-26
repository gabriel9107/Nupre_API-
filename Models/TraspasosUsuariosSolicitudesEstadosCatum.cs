using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosUsuariosSolicitudesEstadosCatum
{
    /// <summary>
    /// Número único que representa el estado de la solicitud que realiza el usuario a traves de la oficina virtual.
    /// </summary>
    public byte SolicitudEstadoNumero { get; set; }

    /// <summary>
    /// Descripción del estado de la solicitud que realiza el usuario en la oficina virtual.
    /// </summary>
    public string SolicitudEstadoDescripcion { get; set; } = null!;

    /// <summary>
    /// Indica si el estado de la solicitud realizada por el usuario en la oficina virtual se realiza por un proceso (S=SI,N=NO).
    /// </summary>
    public string SolicitudEstadoProceso { get; set; } = null!;

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

    public virtual ICollection<TraspasosUsuariosSolicitudesTran> TraspasosUsuariosSolicitudesTrans { get; set; } = new List<TraspasosUsuariosSolicitudesTran>();
}
