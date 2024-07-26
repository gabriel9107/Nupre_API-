using System;
using System.Collections.Generic;

namespace Nupre_API.Models;

public partial class ProfesionalesAsociacionesSolicitudesHistorico
{
    public int SolicitudAsociacionNumero { get; set; }

    public DateTime SolicitudFecha { get; set; }

    public int AsociacionRegistroPatronal { get; set; }

    public string? AsociacionSiglas { get; set; }

    public byte SolicitudEstadoNumero { get; set; }

    public DateTime SolicitudEstadoFecha { get; set; }

    public string SolicitudEstadoNota { get; set; } = null!;

    public string SolicitudUsuarioCuenta { get; set; } = null!;

    public byte MotivoNumero { get; set; }

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

    /// <summary>
    /// Indica la fecha de cuando se insertó o se actualizó un registro en una tabla.
    /// </summary>
    public DateTime RegistroFechaHistorico { get; set; }

    public virtual ProfesionalesAsociacionesSolicitudesTran SolicitudAsociacionNumeroNavigation { get; set; } = null!;
}
