using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class TraspasosUsuariosAsignacionesTran
{
    public byte TraspasoSolicitudTipoNumero { get; set; }

    public long Nuct { get; set; }

    public int EmpleadoNumero { get; set; }

    public int EmpleadoSupervisorNumero { get; set; }

    public byte AccionNumero { get; set; }

    public string SolicitudNotificacionEnviada { get; set; } = null!;

    public DateTime SolicitudNotificacionEnviadaFecha { get; set; }

    /// <summary>
    /// A = Activo, I = Inactivo.
    /// </summary>
    public string RegistroEstado { get; set; } = null!;

    /// <summary>
    /// Registro del usuario.
    /// </summary>
    public string RegistroUsuario { get; set; } = null!;

    /// <summary>
    /// Fecha de registro.
    /// </summary>
    public DateTime RegistroFecha { get; set; }
}
